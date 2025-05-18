using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
			string[] lines;

			using (WebClient client = new WebClient())
			{
				string content = client.DownloadString(url);
				lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			}

			long memoryBefore = GC.GetTotalMemory(true);

			var root = new LightElementNode("div", DisplayType.Block, TagClosingType.Pair);
			var tagFactory = new TagFactory();

			foreach (var line in lines)
			{
				LightElementNode element;
				if (line == lines[0])
				{
					element = tagFactory.GetTag("h1", DisplayType.Block, TagClosingType.Pair);
				}
				else if (line.Length < 20)
				{
					element = tagFactory.GetTag("h2", DisplayType.Block, TagClosingType.Pair);
				}
				else if (char.IsWhiteSpace(line[0]))
				{
					element = tagFactory.GetTag("blockquote", DisplayType.Block, TagClosingType.Pair);
				}
				else
				{
					element = tagFactory.GetTag("p", DisplayType.Block, TagClosingType.Pair);
				}

				var realElement = new LightElementNode(element.TagName, element.Display, element.ClosingType);
				foreach (var cls in element.CssClasses)
					realElement.AddClass(cls);

				realElement.AddChild(new LightTextNode(line));
				root.AddChild(realElement);
			}

			long memoryAfter = GC.GetTotalMemory(true);
			long memoryUsed = memoryAfter - memoryBefore;

			Console.WriteLine(root.OuterHTML);
			Console.WriteLine($"\nMemory used: {memoryUsed} byte");
		}

	}
}

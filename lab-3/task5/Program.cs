using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var ul = new LightElementNode("ul", DisplayType.Block, TagClosingType.Pair);
			ul.AddClass("fancy-list");

			var li1 = new LightElementNode("li", DisplayType.Block, TagClosingType.Pair);
			li1.AddChild(new LightTextNode("First item"));

			var li2 = new LightElementNode("li", DisplayType.Block, TagClosingType.Pair);
			li2.AddChild(new LightTextNode("Second item"));

			var li3 = new LightElementNode("li", DisplayType.Block, TagClosingType.Pair);
			li3.AddChild(new LightTextNode("Third item"));

			ul.AddChild(li1);
			ul.AddChild(li2);
			ul.AddChild(li3);

			Console.WriteLine("=== InnerHTML ===");
			Console.WriteLine(ul.InnerHTML);

			Console.WriteLine("\n=== OuterHTML ===");
			Console.WriteLine(ul.OuterHTML);

			Console.ReadLine();
		}
	}
}

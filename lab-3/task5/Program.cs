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

			ul.AddChild(new LightElementNode("li", DisplayType.Block, TagClosingType.Pair)
			{
				Children = { new LightTextNode("First item") }
			});

			ul.AddChild(new LightElementNode("li", DisplayType.Block, TagClosingType.Pair)
			{
				Children = { new LightTextNode("Second item") }
			});

			ul.AddChild(new LightElementNode("li", DisplayType.Block, TagClosingType.Pair)
			{
				Children = { new LightTextNode("Third item") }
			});

			var fileImage = new ImageElementNode("C:/images/photo.png", new FileImageLoader());
			var webImage = new ImageElementNode("https://example.com/image.jpg", new WebImageLoader());

			var div = new LightElementNode("div", DisplayType.Block, TagClosingType.Pair);
			div.AddClass("container");
			div.AddChild(ul);
			div.AddChild(fileImage);
			div.AddChild(webImage);

			Console.WriteLine("=== OuterHTML ===");
			Console.WriteLine(div.OuterHTML);

			Console.ReadLine();
		}

	}
}

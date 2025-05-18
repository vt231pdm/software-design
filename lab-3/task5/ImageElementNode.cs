using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class ImageElementNode : LightNode
	{
		public string Href { get; }
		public IImageLoader Loader { get; }

		public ImageElementNode(string href, IImageLoader loader)
		{
			Href = href;
			Loader = loader;
		}

		public override string InnerHTML => "";

		public override string OuterHTML => $"<img src=\"{Href}\" alt=\"{Loader.LoadImage(Href)}\" />";
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class WebImageLoader : IImageLoader
	{
		public string LoadImage(string href)
		{
			return $"[Loaded image from web: {href}]";
		}
	}

}

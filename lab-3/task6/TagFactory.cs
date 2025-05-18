using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	public class TagFactory
	{
		private Dictionary<string, LightElementNode> _tags = new Dictionary<string, LightElementNode>();

		public LightElementNode GetTag(string tagName, DisplayType display, TagClosingType closingType)
		{
			string key = $"{tagName}_{display}_{closingType}";
			if (!_tags.ContainsKey(key))
			{
				_tags[key] = new LightElementNode(tagName, display, closingType);
			}
			return _tags[key];
		}
	}
}

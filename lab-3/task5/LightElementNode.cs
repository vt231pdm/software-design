using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public enum DisplayType { Block, Inline }
	public enum TagClosingType { Pair, SelfClosing }

	public class LightElementNode : LightNode
	{
		public string TagName { get; }
		public DisplayType Display { get; }
		public TagClosingType ClosingType { get; }
		public List<string> CssClasses { get; }
		public List<LightNode> Children { get; }

		public LightElementNode(string tagName, DisplayType display, TagClosingType closingType)
		{
			TagName = tagName;
			Display = display;
			ClosingType = closingType;
			CssClasses = new List<string>();
			Children = new List<LightNode>();
		}

		public void AddClass(string cssClass)
		{
			CssClasses.Add(cssClass);
		}

		public void AddChild(LightNode child)
		{
			if (ClosingType == TagClosingType.SelfClosing)
				throw new InvalidOperationException("Cannot add children to a self-closing tag.");

			Children.Add(child);
		}

		public override string InnerHTML
		{
			get
			{
				var sb = new StringBuilder();
				foreach (var child in Children)
				{
					sb.Append(child.OuterHTML);
				}
				return sb.ToString();
			}
		}

		public override string OuterHTML
		{
			get
			{
				var sb = new StringBuilder();
				sb.Append($"<{TagName}");

				if (CssClasses.Count > 0)
					sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");

				if (ClosingType == TagClosingType.SelfClosing)
				{
					sb.Append(" />");
					return sb.ToString();
				}

				sb.Append(">");
				sb.Append(InnerHTML);
				sb.Append($"</{TagName}>");

				return sb.ToString();
			}
		}
	}
}

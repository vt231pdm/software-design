using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class TextDocumentMemento
	{
		public string SavedContent { get; }

		public TextDocumentMemento(string content)
		{
			SavedContent = content;
		}
	}
}

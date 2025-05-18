using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class TextEditor
	{
		private TextDocument _document = new TextDocument();
		private Stack<TextDocumentMemento> _history = new Stack<TextDocumentMemento>();

		public void Write(string text)
		{
			Save(); 
			_document.Write(text);
		}

		public void EraseLast(int count)
		{
			Save();
			_document.EraseLast(count);
		}

		public void Undo()
		{
			if (_history.Count > 0)
			{
				var memento = _history.Pop();
				_document = new TextDocument();
				_document.Write(memento.SavedContent);
			}
			else
			{
				Console.WriteLine("No changes to cancel.");
			}
		}

		public void Print()
		{
			Console.WriteLine($"Document: \"{_document}\"");
		}

		private void Save()
		{
			_history.Push(new TextDocumentMemento(_document.ToString()));
		}
	}
}

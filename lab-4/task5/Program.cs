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
			TextEditor editor = new TextEditor();

			editor.Write("Hello");
			editor.Print();

			editor.Write(" world!");
			editor.Print();

			editor.EraseLast(6);
			editor.Print();

			Console.WriteLine("Undo the last action...");
			editor.Undo();
			editor.Print();

			Console.WriteLine("Undo another action...");
			editor.Undo();
			editor.Print();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	public class SmartTextChecker : ISmartTextReader
	{
		private readonly ISmartTextReader _reader;

		public SmartTextChecker(ISmartTextReader reader)
		{
			_reader = reader;
		}

		public char[][] ReadText(string filePath)
		{
			Console.WriteLine($"[Checker] Opening file: {filePath}");

			char[][] result = _reader.ReadText(filePath);

			int lineCount = result.Length;
			int charCount = 0;
			foreach (var line in result)
			{
				charCount += line.Length;
			}

			Console.WriteLine($"[Checker] Successfully read file: {filePath}");
			Console.WriteLine($"[Checker] Lines: {lineCount}, Characters: {charCount}");
			Console.WriteLine($"[Checker] Closing file: {filePath}");

			return result;
		}
	}
}

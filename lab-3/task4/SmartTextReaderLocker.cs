using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
	public class SmartTextReaderLocker : ISmartTextReader
	{
		private readonly ISmartTextReader _reader;
		private readonly Regex _denyPattern;

		public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
		{
			_reader = reader;
			_denyPattern = new Regex(pattern, RegexOptions.IgnoreCase);
		}

		public char[][] ReadText(string filePath)
		{
			if (_denyPattern.IsMatch(filePath))
			{
				Console.WriteLine("Access denied!");
				return Array.Empty<char[]>();
			}

			return _reader.ReadText(filePath);
		}
	}
}

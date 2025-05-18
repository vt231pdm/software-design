using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
	public class SmartTextReader : ISmartTextReader
	{
		public char[][] ReadText(string filePath)
		{
			string[] lines = File.ReadAllLines(filePath);
			return lines.Select(line => line.ToCharArray()).ToArray();
		}
	}
}

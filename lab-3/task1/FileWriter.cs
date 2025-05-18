﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
	public class FileWriter
	{
		private string _filePath;

		public FileWriter(string filePath)
		{
			_filePath = filePath;
		}

		public void Write(string message)
		{
			File.AppendAllText(_filePath, message);
		}

		public void WriteLine(string message)
		{
			File.AppendAllText(_filePath, message + "\n");
		}
	}
}

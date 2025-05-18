﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Logger
	{
		public void Log(string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("[INFO] " + message);
			Console.ResetColor();
		}

		public void Warn(string message)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("[WARN] " + message);
			Console.ResetColor();
		}

		public void Error(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("[ERROR] " + message);
			Console.ResetColor();
		}
	}
}

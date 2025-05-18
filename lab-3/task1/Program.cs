using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Logger consoleLogger = new Logger();
			consoleLogger.Log("Application started");
			consoleLogger.Warn("Low disk space");
			consoleLogger.Error("Unhandled exception");

			FileWriter writer = new FileWriter("log.txt");
			ILog fileLogger = new FileLoggerAdapter(writer);

			fileLogger.Log("Application started (File)");
			fileLogger.Warn("Low disk space (File)");
			fileLogger.Error("Unhandled exception (File)");

			Console.WriteLine("\nMessages were logged to file 'log.txt'");
			Console.ReadLine();
		}
	}
}

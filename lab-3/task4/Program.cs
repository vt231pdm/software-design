using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string allowedFile = "allowed.txt";
			string deniedFile = "secret.lock";

			File.WriteAllText(allowedFile, "Hello\nWorld");
			File.WriteAllText(deniedFile, "This is secret!");

			ISmartTextReader reader = new SmartTextReader();

			ISmartTextReader checker = new SmartTextChecker(reader);
			Console.WriteLine("=== Checker ===");
			checker.ReadText(allowedFile);

			ISmartTextReader locker = new SmartTextReaderLocker(reader, @"\.lock$");
			Console.WriteLine("\n=== Locker - Allowed file ===");
			locker.ReadText(allowedFile);

			Console.WriteLine("\n=== Locker - Denied file ===");
			locker.ReadText(deniedFile);

			Console.ReadLine();
		}
	}
}

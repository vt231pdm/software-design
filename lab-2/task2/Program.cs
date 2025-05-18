using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Factories;

namespace task2
{
	internal class Program
	{
		static void DisplayDevices(IDeviceFactory factory, string brandName)
		{
			Console.WriteLine($"\n=== Devices from {brandName} ===");
			factory.CreateLaptop().ShowInfo();
			factory.CreateNetbook().ShowInfo();
			factory.CreateEBook().ShowInfo();
			factory.CreateSmartphone().ShowInfo();
		}
		static void Main(string[] args)
		{
			DisplayDevices(new IProneFactory(), "IProne");
			DisplayDevices(new KiaomiFactory(), "Kiaomi");
			DisplayDevices(new BalaxyFactory(), "Balaxy");

			Console.ReadLine();
		}
	}
}

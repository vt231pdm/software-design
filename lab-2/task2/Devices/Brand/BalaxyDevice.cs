using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices.Brand
{
	public class BalaxyLaptop : ILaptop
	{
		public void ShowInfo() => Console.WriteLine("Laptop from Balaxy");
	}

	public class BalaxyNetbook : INetbook
	{
		public void ShowInfo() => Console.WriteLine("Netbook from Balaxy");
	}

	public class BalaxyEBook : IEBook
	{
		public void ShowInfo() => Console.WriteLine("EBook from Balaxy");
	}

	public class BalaxySmartphone : ISmartphone
	{
		public void ShowInfo() => Console.WriteLine("Smartphone from Balaxy");
	}

}

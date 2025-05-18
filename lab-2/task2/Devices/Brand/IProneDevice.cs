using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices.Brand
{
	public class IProneLaptop : ILaptop
	{
		public void ShowInfo() => Console.WriteLine("Laptop from IProne");
	}

	public class IProneNetbook : INetbook
	{
		public void ShowInfo() => Console.WriteLine("Netbook from IProne");
	}

	public class IProneEBook : IEBook
	{
		public void ShowInfo() => Console.WriteLine("EBook from IProne");
	}

	public class IProneSmartphone : ISmartphone
	{
		public void ShowInfo() => Console.WriteLine("Smartphone from IProne");
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Devices.Brand
{
	public class KiaomiLaptop : ILaptop
	{
		public void ShowInfo() => Console.WriteLine("Laptop from Kiaomi");
	}

	public class KiaomiNetbook : INetbook
	{
		public void ShowInfo() => Console.WriteLine("Netbook from Kiaomi");
	}

	public class KiaomiEBook : IEBook
	{
		public void ShowInfo() => Console.WriteLine("EBook from Kiaomi");
	}

	public class KiaomiSmartphone : ISmartphone
	{
		public void ShowInfo() => Console.WriteLine("Smartphone from Kiaomi");
	}

}

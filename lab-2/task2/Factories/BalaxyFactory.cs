using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices.Brand;
using task2.Devices;

namespace task2.Factories
{
	public class BalaxyFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop() => new BalaxyLaptop();
		public INetbook CreateNetbook() => new BalaxyNetbook();
		public IEBook CreateEBook() => new BalaxyEBook();
		public ISmartphone CreateSmartphone() => new BalaxySmartphone();
	}

}

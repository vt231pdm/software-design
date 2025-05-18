using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;
using task2.Devices.Brand;

namespace task2.Factories
{
	public class KiaomiFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop() => new KiaomiLaptop();
		public INetbook CreateNetbook() => new KiaomiNetbook();
		public IEBook CreateEBook() => new KiaomiEBook();
		public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
	}

}

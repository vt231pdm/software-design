using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
	public interface IDeviceFactory
	{
		ILaptop CreateLaptop();
		INetbook CreateNetbook();
		IEBook CreateEBook();
		ISmartphone CreateSmartphone();
	}

}

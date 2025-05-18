﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;
using task2.Devices.Brand;

namespace task2.Factories
{
	public class IProneFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop() => new IProneLaptop();
		public INetbook CreateNetbook() => new IProneNetbook();
		public IEBook CreateEBook() => new IProneEBook();
		public ISmartphone CreateSmartphone() => new IProneSmartphone();
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public interface IEventListener
	{
		void HandleEvent(string eventType, LightElementNode target);
	}
}

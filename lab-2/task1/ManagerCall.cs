﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class ManagerCall : SubscriptionCreator
	{
		public override Subscription CreateSubscription()
		{
			return new PremiumSubscription();
		}
	}

}

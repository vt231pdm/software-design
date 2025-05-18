using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class BillingSupport : SupportHandler
	{
		public override bool Handle(string input)
		{
			if (input == "3")
			{
				Console.WriteLine("Billing Support: Checking invoices and payments...");
				return true;
			}
			return _nextHandler?.Handle(input) ?? false;
		}
	}
}

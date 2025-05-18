using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class OperatorSupport : SupportHandler
	{
		public override bool Handle(string input)
		{
			if (input == "4")
			{
				Console.WriteLine("Operator: Connecting to the operator. Please wait....");
				return true;
			}
			return false;
		}
	}
}

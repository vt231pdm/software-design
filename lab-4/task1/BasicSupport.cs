using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class BasicSupport : SupportHandler
	{
		public override bool Handle(string input)
		{
			if (input == "1")
			{
				Console.WriteLine("Basic Support: We will help you with simple questions.");
				return true;
			}
			return _nextHandler?.Handle(input) ?? false;
		}
	}
}

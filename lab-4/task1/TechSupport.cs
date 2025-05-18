using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class TechSupport : SupportHandler
	{
		public override bool Handle(string input)
		{
			if (input == "2")
			{
				Console.WriteLine("Tech Support: We connect with a technical specialist...");
				return true;
			}
			return _nextHandler?.Handle(input) ?? false;
		}
	}
}

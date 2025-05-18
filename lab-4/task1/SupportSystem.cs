using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class SupportSystem
	{
		private readonly SupportHandler _chain;

		public SupportSystem()
		{
			var basic = new BasicSupport();
			var tech = new TechSupport();
			var billing = new BillingSupport();
			var operatorSupport = new OperatorSupport();

			basic.SetNext(tech);
			tech.SetNext(billing);
			billing.SetNext(operatorSupport);

			_chain = basic;
		}

		public void Start()
		{
			bool resolved = false;
			while (!resolved)
			{
				Console.WriteLine("\nWelcome to the support system:");
				Console.WriteLine("1. General questions");
				Console.WriteLine("2. Technical support");
				Console.WriteLine("3. Payment issues");
				Console.WriteLine("4. Operator");
				Console.Write("Your choice: ");
				string input = Console.ReadLine();

				resolved = _chain.Handle(input);

				if (!resolved)
				{
					Console.WriteLine("Incorrect choice. Try again..");
				}
			}

			Console.WriteLine("\nThank you for your request!");
		}
	}
}

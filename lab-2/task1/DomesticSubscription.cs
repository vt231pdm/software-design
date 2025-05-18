using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class DomesticSubscription : Subscription
	{
		public DomesticSubscription()
		{
			MonthlyFee = 100;
			MinPeriodMonths = 1;
			Channels = new List<string> { "National TV", "Family Channel", "Cooking Show" };
			Features = new List<string> { "Basic Support" };
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("=== Domestic Subscription ===");
			Console.WriteLine($"Monthly Fee: {MonthlyFee} UAH");
			Console.WriteLine($"Min Period: {MinPeriodMonths} months");
			Console.WriteLine("Channels: " + string.Join(", ", Channels));
			Console.WriteLine("Features: " + string.Join(", ", Features));
		}
	}
}

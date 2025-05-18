using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class PremiumSubscription : Subscription
	{
		public PremiumSubscription()
		{
			MonthlyFee = 250;
			MinPeriodMonths = 3;
			Channels = new List<string> { "HBO", "Netflix", "National Geographic", "Sports HD" };
			Features = new List<string> { "4K Streaming", "Offline Download", "Premium Support" };
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("=== Premium Subscription ===");
			Console.WriteLine($"Monthly Fee: {MonthlyFee} UAH");
			Console.WriteLine($"Min Period: {MinPeriodMonths} months");
			Console.WriteLine("Channels: " + string.Join(", ", Channels));
			Console.WriteLine("Features: " + string.Join(", ", Features));
		}
	}
}

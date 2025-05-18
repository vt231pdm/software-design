using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class EducationalSubscription : Subscription
	{
		public EducationalSubscription()
		{
			MonthlyFee = 80;
			MinPeriodMonths = 6;
			Channels = new List<string> { "Discovery", "History", "Science Kids" };
			Features = new List<string> { "Parental Control", "Quiz Access" };
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("=== Educational Subscription ===");
			Console.WriteLine($"Monthly Fee: {MonthlyFee} UAH");
			Console.WriteLine($"Min Period: {MinPeriodMonths} months");
			Console.WriteLine("Channels: " + string.Join(", ", Channels));
			Console.WriteLine("Features: " + string.Join(", ", Features));
		}
	}
}

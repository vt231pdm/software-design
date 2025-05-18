using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SubscriptionCreator web = new WebSite();
			Subscription webSubscription = web.CreateSubscription();
			webSubscription.DisplayInfo();
			Console.WriteLine();

			SubscriptionCreator app = new MobileApp();
			Subscription appSubscription = app.CreateSubscription();
			appSubscription.DisplayInfo();
			Console.WriteLine();

			SubscriptionCreator call = new ManagerCall();
			Subscription callSubscription = call.CreateSubscription();
			callSubscription.DisplayInfo();
		}
	}
}

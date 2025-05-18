using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public abstract class Subscription
	{
		public decimal MonthlyFee { get; protected set; }
		public int MinPeriodMonths { get; protected set; }
		public List<string> Channels { get; protected set; }
		public List<string> Features { get; protected set; }

		public abstract void DisplayInfo();
	}
}

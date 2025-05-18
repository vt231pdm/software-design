using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Money
	{
		private int wholePart; 
		private int cents;     

		public Money(int whole = 0, int cents = 0)
		{
			SetMoney(whole, cents);
		}

		public void SetMoney(int whole, int cents)
		{
			this.wholePart = whole + cents / 100;
			this.cents = cents % 100;
		}

		public void Display()
		{
			Console.WriteLine($"{wholePart} uah {cents:D2} kop.");
		}

		public decimal ToDecimal() => wholePart + cents / 100.0m;

		public void SetFromDecimal(decimal value)
		{
			wholePart = (int)value;
			cents = (int)((value - wholePart) * 100);
		}
	}
}

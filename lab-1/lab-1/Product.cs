using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Product
	{
		public string Name { get; set; }
		public Money Price { get; set; }

		public Product(string name, Money price)
		{
			Name = name;
			Price = price;
		}

		public void DecreasePrice(decimal amount)
		{
			decimal newPrice = Price.ToDecimal() - amount;
			if (newPrice < 0) newPrice = 0;
			Price.SetFromDecimal(newPrice);
		}

		public void Display()
		{
			Console.Write($"Product: {Name}, Price: ");
			Price.Display();
		}
	}
}

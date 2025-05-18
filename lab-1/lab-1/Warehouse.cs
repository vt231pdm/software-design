using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Warehouse
	{
		public string Name { get; set; }
		public string Unit { get; set; }
		public Money UnitPrice { get; set; }
		public int Quantity { get; set; }
		public DateTime LastDeliveryDate { get; set; }

		public Warehouse(string name, string unit, Money price, int quantity, DateTime deliveryDate)
		{
			Name = name;
			Unit = unit;
			UnitPrice = price;
			Quantity = quantity;
			LastDeliveryDate = deliveryDate;
		}

		public void Display()
		{
			Console.WriteLine($"Warehouse Item: {Name}");
			Console.WriteLine($"Unit: {Unit}, Quantity: {Quantity}");
			Console.Write($"Unit Price: ");
			UnitPrice.Display();
			Console.WriteLine($"Last Delivery: {LastDeliveryDate.ToShortDateString()}");
		}
	}
}
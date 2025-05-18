using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	class Program
	{
		static void Main()
		{
			Money money = new Money(123, 45);
			Console.Write("Initial money: ");
			money.Display();

			Product product = new Product("Laptop", new Money(15000, 0));
			product.Display();
			product.DecreasePrice(2000);
			Console.WriteLine("After discount:");
			product.Display();

			Warehouse item1 = new Warehouse("Laptop", "pcs", new Money(13000, 0), 10, DateTime.Now);
			Warehouse item2 = new Warehouse("Mouse", "pcs", new Money(500, 50), 50, DateTime.Now);

			Reporting report = new Reporting();
			report.RegisterArrival(item1);
			report.RegisterArrival(item2);

			report.RegisterShipment("Laptop", 3);
			report.RegisterShipment("Mouse", 10);

			report.InventoryReport();
		}
	}
}
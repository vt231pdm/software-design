using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Reporting
	{
		private List<Warehouse> inventory = new List<Warehouse>();

		public void RegisterArrival(Warehouse item)
		{
			inventory.Add(item);
			Console.WriteLine($"Arrival registered: {item.Name} - {item.Quantity} {item.Unit}");
		}

		public void RegisterShipment(string productName, int quantity)
		{
			var item = inventory.Find(i => i.Name == productName);
			if (item != null && item.Quantity >= quantity)
			{
				item.Quantity -= quantity;
				Console.WriteLine($"Shipped {quantity} {item.Unit} of {productName}");
			}
			else
			{
				Console.WriteLine("Shipment failed: not enough stock or item not found.");
			}
		}

		public void InventoryReport()
		{
			Console.WriteLine("\nInventory Report:");
			foreach (var item in inventory)
			{
				item.Display();
				Console.WriteLine();
			}
		}
	}
}

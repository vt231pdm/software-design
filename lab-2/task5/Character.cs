using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class Character
	{
		public string Role { get; set; }
		public string BodyType { get; set; }
		public double Height { get; set; }
		public string HairColor { get; set; }
		public string EyeColor { get; set; }
		public string Outfit { get; set; }
		public List<string> Inventory { get; set; } = new List<string>();
		public List<string> Deeds { get; set; } = new List<string>();

		public void Show()
		{
			Console.WriteLine($"\n=== {Role} ===");
			Console.WriteLine($"Height: {Height} cm");
			Console.WriteLine($"Body Type: {BodyType}");
			Console.WriteLine($"Hair Color: {HairColor}");
			Console.WriteLine($"Eye Color: {EyeColor}");
			Console.WriteLine($"Outfit: {Outfit}");
			Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
			Console.WriteLine("Deeds: " + string.Join("; ", Deeds));
		}
	}
}

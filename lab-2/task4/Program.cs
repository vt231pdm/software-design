using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Virus grandparent = new Virus("Alpha", "Corona", 5, 0.9);
			Virus parent1 = new Virus("Beta", "Corona", 3, 0.5);
			Virus parent2 = new Virus("Gamma", "Corona", 3, 0.45);
			Virus child1 = new Virus("Delta", "Corona", 1, 0.2);
			Virus child2 = new Virus("Epsilon", "Corona", 1, 0.25);

			parent1.AddChild(child1);
			parent2.AddChild(child2);

			grandparent.AddChild(parent1);
			grandparent.AddChild(parent2);

			Console.WriteLine("Original family of viruses:");
			grandparent.Print();

			Console.WriteLine("\nCloned family of viruses:");
			Virus clone = (Virus)grandparent.Clone();
			clone.Print();

			Console.ReadLine();
		}
	}
}

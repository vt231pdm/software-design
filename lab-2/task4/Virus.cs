using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	public class Virus : ICloneable
	{
		public string Name { get; set; }
		public string Species { get; set; }
		public int Age { get; set; }
		public double Weight { get; set; }
		public List<Virus> Children { get; set; }

		public Virus(string name, string species, int age, double weight)
		{
			Name = name;
			Species = species;
			Age = age;
			Weight = weight;
			Children = new List<Virus>();
		}
		
		public object Clone()
		{
			Virus clone = new Virus(Name, Species, Age, Weight);
			foreach (var child in Children)
			{
				clone.Children.Add((Virus)child.Clone());
			}
			return clone;
		}

		public void AddChild(Virus child)
		{
			Children.Add(child);
		}

		public void Print(string indent = "")
		{
			Console.WriteLine($"{indent}- {Name} ({Species}), Age: {Age}, Weight: {Weight}g");

			foreach (var child in Children)
			{
				child.Print(indent + "  ");
			}
		}
	}
}

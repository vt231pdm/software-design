using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IHero warrior = new Warrior();
			warrior = new Weapon(warrior);
			warrior = new Armor(warrior);
			warrior = new Artifact(warrior);
			Console.WriteLine($"{warrior.GetDescription()} has power {warrior.GetPower()}");

			IHero mage = new Mage();
			mage = new Artifact(new Weapon(new Artifact(mage)));
			Console.WriteLine($"{mage.GetDescription()} has power {mage.GetPower()}");

			IHero paladin = new Paladin();
			paladin = new Armor(new Armor(new Weapon(paladin)));
			Console.WriteLine($"{paladin.GetDescription()} has power {paladin.GetPower()}");

			Console.ReadLine();
		}
	}
}

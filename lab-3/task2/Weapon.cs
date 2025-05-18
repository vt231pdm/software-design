using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Weapon : HeroDecorator
	{
		public Weapon(IHero hero) : base(hero) { }

		public override string GetDescription() => _hero.GetDescription() + " + Weapon";
		public override int GetPower() => _hero.GetPower() + 5;
	}
}

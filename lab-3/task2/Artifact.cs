using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Artifact : HeroDecorator
	{
		public Artifact(IHero hero) : base(hero) { }

		public override string GetDescription() => _hero.GetDescription() + " + Artifact";
		public override int GetPower() => _hero.GetPower() + 2;
	}
}

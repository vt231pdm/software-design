﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public abstract class HeroDecorator : IHero
	{
		protected IHero _hero;

		public HeroDecorator(IHero hero)
		{
			_hero = hero;
		}

		public virtual string GetDescription() => _hero.GetDescription();
		public virtual int GetPower() => _hero.GetPower();
	}

}

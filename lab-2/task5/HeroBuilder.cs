using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class HeroBuilder : ICharacterBuilder
	{
		private Character _hero = new Character { Role = "Hero" };

		public ICharacterBuilder SetHeight(double height)
		{
			_hero.Height = height;
			return this;
		}

		public ICharacterBuilder SetBodyType(string bodyType)
		{
			_hero.BodyType = bodyType;
			return this;
		}

		public ICharacterBuilder SetHairColor(string color)
		{
			_hero.HairColor = color;
			return this;
		}

		public ICharacterBuilder SetEyeColor(string color)
		{
			_hero.EyeColor = color;
			return this;
		}

		public ICharacterBuilder SetOutfit(string outfit)
		{
			_hero.Outfit = outfit;
			return this;
		}

		public ICharacterBuilder AddItemToInventory(string item)
		{
			_hero.Inventory.Add(item);
			return this;
		}

		public ICharacterBuilder AddDeed(string deed)
		{
			_hero.Deeds.Add("Good: " + deed);
			return this;
		}

		public Character Build()
		{
			return _hero;
		}
	}

}

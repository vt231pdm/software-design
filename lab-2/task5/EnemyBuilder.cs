using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class EnemyBuilder : ICharacterBuilder
	{
		private Character _enemy = new Character { Role = "Enemy" };

		public ICharacterBuilder SetHeight(double height)
		{
			_enemy.Height = height;
			return this;
		}

		public ICharacterBuilder SetBodyType(string bodyType)
		{
			_enemy.BodyType = bodyType;
			return this;
		}

		public ICharacterBuilder SetHairColor(string color)
		{
			_enemy.HairColor = color;
			return this;
		}

		public ICharacterBuilder SetEyeColor(string color)
		{
			_enemy.EyeColor = color;
			return this;
		}

		public ICharacterBuilder SetOutfit(string outfit)
		{
			_enemy.Outfit = outfit;
			return this;
		}

		public ICharacterBuilder AddItemToInventory(string item)
		{
			_enemy.Inventory.Add(item);
			return this;
		}

		public ICharacterBuilder AddDeed(string deed)
		{
			_enemy.Deeds.Add("Evil: " + deed);
			return this;
		}

		public Character Build()
		{
			return _enemy;
		}
	}
}

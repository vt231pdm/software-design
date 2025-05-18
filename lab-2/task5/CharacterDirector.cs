using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class CharacterDirector
	{
		public Character CreateHero(ICharacterBuilder builder)
		{
			return builder
				.SetHeight(185)
				.SetBodyType("Athletic")
				.SetHairColor("Brown")
				.SetEyeColor("Blue")
				.SetOutfit("Golden Armor")
				.AddItemToInventory("Sword of Light")
				.AddItemToInventory("Healing Potion")
				.AddDeed("Saved the village")
				.AddDeed("Defeated the dark mage")
				.Build();
		}

		public Character CreateEnemy(ICharacterBuilder builder)
		{
			return builder
				.SetHeight(190)
				.SetBodyType("Muscular")
				.SetHairColor("Black")
				.SetEyeColor("Red")
				.SetOutfit("Dark Cloak")
				.AddItemToInventory("Cursed Staff")
				.AddItemToInventory("Poison Vial")
				.AddDeed("Destroyed the forest")
				.AddDeed("Kidnapped the princess")
				.Build();
		}
	}

}

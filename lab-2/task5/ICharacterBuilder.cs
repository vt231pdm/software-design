using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public interface ICharacterBuilder
	{
		ICharacterBuilder SetHeight(double height);
		ICharacterBuilder SetBodyType(string bodyType);
		ICharacterBuilder SetHairColor(string color);
		ICharacterBuilder SetEyeColor(string color);
		ICharacterBuilder SetOutfit(string outfit);
		ICharacterBuilder AddItemToInventory(string item);
		ICharacterBuilder AddDeed(string deed);
		Character Build();
	}
}

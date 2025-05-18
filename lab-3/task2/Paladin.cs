using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Paladin : IHero
	{
		public string GetDescription() => "Paladin";
		public int GetPower() => 9;
	}
}

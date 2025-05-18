using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Runway
	{
		public readonly Guid Id = Guid.NewGuid();
		public Aircraft IsBusyWithAircraft;

		public Runway()
		{
			IsBusyWithAircraft = null;
		}

		public bool IsAvailable => IsBusyWithAircraft == null;

		public void Occupy(Aircraft aircraft)
		{
			IsBusyWithAircraft = aircraft;
			HighLightRed();
		}

		public void Release()
		{
			IsBusyWithAircraft = null;
			HighLightGreen();
		}

		public void HighLightRed()
		{
			Console.WriteLine($"Runway {Id} is now BUSY.");
		}

		public void HighLightGreen()
		{
			Console.WriteLine($"Runway {Id} is now FREE.");
		}
	}
}

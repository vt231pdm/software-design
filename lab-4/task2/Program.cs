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
			Runway r1 = new Runway();
			Runway r2 = new Runway();

			CommandCentre centre = new CommandCentre(new[] { r1, r2 });

			Aircraft a1 = new Aircraft("Boeing 747", centre);
			Aircraft a2 = new Aircraft("Airbus A320", centre);
			Aircraft a3 = new Aircraft("F-16 Falcon", centre);

			centre.RegisterAircrafts(new[] { a1, a2, a3 });

			a1.RequestLanding();
			a2.RequestLanding();
			a3.RequestLanding(); 

			a1.RequestTakeOff();

			a3.RequestLanding(); 
		}
	}
}

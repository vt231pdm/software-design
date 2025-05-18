using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Aircraft
	{
		public string Name { get; }
		public bool IsTakingOff { get; set; }
		private ICommandCentre _commandCentre;

		public Aircraft(string name, ICommandCentre commandCentre)
		{
			this.Name = name;
			this._commandCentre = commandCentre;
		}

		public void RequestLanding()
		{
			Console.WriteLine($"\n[Aircraft {Name}] requesting landing.");
			_commandCentre.RequestLanding(this);
		}

		public void RequestTakeOff()
		{
			Console.WriteLine($"\n[Aircraft {Name}] requesting takeoff.");
			_commandCentre.RequestTakeOff(this);
		}
	}
}

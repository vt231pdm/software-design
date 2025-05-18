using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class CommandCentre : ICommandCentre
{
    private List<Runway> _runways = new List<Runway>();
	private List<Aircraft> _aircrafts = new List<Aircraft>();

	public CommandCentre(Runway[] runways)
	{
		this._runways.AddRange(runways);
	}

	public void RegisterAircrafts(Aircraft[] aircrafts)
	{
		this._aircrafts.AddRange(aircrafts);
	}

	public void RequestLanding(Aircraft aircraft)
	{
		var freeRunway = _runways.FirstOrDefault(r => r.IsAvailable);

		if (freeRunway != null)
		{
			Console.WriteLine($"[CommandCentre] Aircraft {aircraft.Name} has landed on runway {freeRunway.Id}.");
			freeRunway.Occupy(aircraft);
		}
		else
		{
			Console.WriteLine($"[CommandCentre] No available runway for Aircraft {aircraft.Name}.");
		}
	}

	public void RequestTakeOff(Aircraft aircraft)
	{
		var runway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == aircraft);

		if (runway != null)
		{
			Console.WriteLine($"[CommandCentre] Aircraft {aircraft.Name} is taking off from runway {runway.Id}.");
			aircraft.IsTakingOff = true;
			runway.Release();
		}
		else
		{
			Console.WriteLine($"[CommandCentre] Aircraft {aircraft.Name} is not on any runway.");
		}
	}
}
}

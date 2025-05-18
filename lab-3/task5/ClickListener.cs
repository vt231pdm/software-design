using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class ClickListener : IEventListener
	{
		private readonly string _listenerName;

		public ClickListener(string name)
		{
			_listenerName = name;
		}

		public void HandleEvent(string eventType, LightElementNode target)
		{
			Console.WriteLine($"[{_listenerName}] Event '{eventType}' received from <{target.TagName}>");
		}
	}

}

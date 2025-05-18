using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	abstract class SupportHandler
	{
		protected SupportHandler _nextHandler;

		public void SetNext(SupportHandler handler)
		{
			_nextHandler = handler;
		}

		public abstract bool Handle(string input);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	public sealed class Authenticator
	{
		private static readonly Lazy<Authenticator> _instance =
			new Lazy<Authenticator>(() => new Authenticator());

		public static Authenticator Instance => _instance.Value;

		public string LoggedUser { get; private set; }

		private Authenticator()
		{
			Console.WriteLine("Authenticator instance created.");
		}

		public void Login(string username)
		{
			LoggedUser = username;
			Console.WriteLine($"User '{username}' logged in.");
		}

		public void Logout()
		{
			Console.WriteLine($"User '{LoggedUser}' logged out.");
			LoggedUser = null;
		}

		public void WhoIsLogged()
		{
			if (LoggedUser != null)
				Console.WriteLine($"Currently logged user: {LoggedUser}");
			else
				Console.WriteLine("No user is logged in.");
		}
	}
}

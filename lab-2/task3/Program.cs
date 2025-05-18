using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var auth1 = Authenticator.Instance;
			auth1.Login("Admin");

			var auth2 = Authenticator.Instance;
			auth2.WhoIsLogged(); 

			Console.WriteLine(Object.ReferenceEquals(auth1, auth2)
				? "auth1 і auth2 - той самий екземпляр"
				: "auth1 і auth2 - різні екземпляри");

			Thread thread1 = new Thread(() =>
			{
				var threadAuth = Authenticator.Instance;
				threadAuth.Login("ThreadUser1");
				threadAuth.WhoIsLogged();
			});

			Thread thread2 = new Thread(() =>
			{
				var threadAuth = Authenticator.Instance;
				threadAuth.WhoIsLogged();
			});

			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();

			Console.ReadLine();
		}
	}
}

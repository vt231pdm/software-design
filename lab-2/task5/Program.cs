using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class Program
	{
		static void Main(string[] args)
		{
			var director = new CharacterDirector();

			var heroBuilder = new HeroBuilder();
			var enemyBuilder = new EnemyBuilder();

			var hero = director.CreateHero(heroBuilder);
			var enemy = director.CreateEnemy(enemyBuilder);

			hero.Show();
			enemy.Show();

			Console.ReadLine();
		}
	}
}

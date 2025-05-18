using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IRenderer vectorRenderer = new VectorRenderer();

			Shape circle = new Circle(vectorRenderer);
			Shape square = new Square(vectorRenderer);

			circle.Draw();  
			square.Draw();  

			IRenderer rasterRenderer = new RasterRenderer();

			Shape triangle = new Triangle(rasterRenderer);
			triangle.Draw(); 

			Console.ReadLine();
		}
	}
}

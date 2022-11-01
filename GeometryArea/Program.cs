using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;

namespace GeometryArea
{
		internal class Program
		{
				static void Main(string[] args)
				{
						Circle circle1 = new Circle("Circle", 10);
						Console.WriteLine("The area of the circle is equal to: " + circle1.calcArea());
						Triangle triangle1 = new Triangle("Triangle", 5, 4, 3);
						Console.WriteLine("The area of the triangle is equal to: " + triangle1.calcArea());
						if (triangle1.isRightTriangle())
								Console.WriteLine("The triangle is right");
						Console.ReadKey();
				}
		}
}
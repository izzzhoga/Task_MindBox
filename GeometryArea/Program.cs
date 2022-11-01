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
						Circle circle1 = new Circle("Круг", 10);
						Console.WriteLine("Площадь круга равна: " + circle1.calcArea());
						Triangle triangle1 = new Triangle("Треугольник", 5, 4, 3);
						Console.WriteLine("Площадь треугольника равна: " + triangle1.calcArea());
						if (triangle1.isRightTriangle())
								Console.WriteLine("Треугольник правильный");
						Console.ReadKey();
				}
		}
}
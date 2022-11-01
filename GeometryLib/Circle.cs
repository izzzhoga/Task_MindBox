using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
		public class Circle : Figure
		{
				public double radius { get; private set; }

				public Circle(string name, double radius) : base(name)
				{
						if (radius > 0) this.radius = radius;
						else throw new Exception("Ошибка: Радиус должен быть положительным числом!");
				}

				public double calcArea()
				{
						return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
				}
		}
}

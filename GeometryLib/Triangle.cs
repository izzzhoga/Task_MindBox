using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
		public class Triangle : Figure
		{
				public double aSide { get; private set; }
				public double bSide { get; private set; }
				public double cSide { get; private set; }

				public Triangle(string name, double aSide, double bSide, double cSide) : base(name)
				{
						if (aSide < 0 || bSide < 0 || cSide < 0)
								throw new Exception("Error! The side of the triangle must have a positive value!");
						else if (aSide + bSide <= cSide
								|| aSide + cSide <= bSide
								|| cSide + bSide <= aSide)
								throw new Exception("Error! The sum of the two sides of the triangle must be greater than the length of the third side!");
						else
						{
								this.aSide = aSide;
								this.bSide = bSide;
								this.cSide = cSide;
						}
				}

				public bool isRightTriangle()
				{
						if (Math.Pow(aSide, 2) == Math.Pow(bSide, 2) + Math.Pow(cSide, 2)
							|| Math.Pow(bSide, 2) == Math.Pow(aSide, 2) + Math.Pow(cSide, 2)
							|| Math.Pow(cSide, 2) == Math.Pow(aSide, 2) + Math.Pow(bSide, 2)) return true;
						else return false;
				}

				public double calcArea()
				{
						double p = (aSide + bSide + cSide) / 2;
						return Math.Round(Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide)), 2);
				}
		}
}

using GeometryLib;

namespace TestGeometryArea
{
		[TestClass]
		public class TestCircleArea
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Circle circleTest = new Circle("Круг", 10);

						double expected = 314.16;
						double result = circleTest.calcArea();
						Assert.AreEqual(expected, result, "Ошибка при тестировании!");
				}
		}

		[TestClass]
		public class TestTriangleArea
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Triangle triangleTest = new Triangle("Треугольник", 5, 4, 3);

						double expected1 = 6;
						double result1 = triangleTest.calcArea();
						Assert.AreEqual(expected1, result1, "Ошибка при тестировании!");
				}
		}

		[TestClass]
		public class TestTriangleRight
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Triangle triangleTest = new Triangle("Треугольник", 5, 4, 3);

						bool expected2 = true;
						bool result2 = triangleTest.isRightTriangle();
						Assert.AreEqual(expected2, result2, "Ошибка при тестировании!");
				}
		}
}
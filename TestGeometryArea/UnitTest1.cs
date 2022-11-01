using GeometryLib;

namespace TestGeometryArea
{
		[TestClass]
		public class TestCircleArea
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Circle circleTest = new Circle("Circle", 10);

						double expected = 314.16;
						double result = circleTest.calcArea();
						Assert.AreEqual(expected, result, "Error during testing!");
				}
		}

		[TestClass]
		public class TestTriangleArea
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Triangle triangleTest = new Triangle("Triangle", 5, 4, 3);

						double expected1 = 6;
						double result1 = triangleTest.calcArea();
						Assert.AreEqual(expected1, result1, "Error during testing!");
				}
		}

		[TestClass]
		public class TestTriangleRight
		{
				[TestMethod]
				public void TestCalcArea()
				{
						Triangle triangleTest = new Triangle("Triangle", 5, 4, 3);

						bool expected2 = true;
						bool result2 = triangleTest.isRightTriangle();
						Assert.AreEqual(expected2, result2, "Error during testing!");
				}
		}
}
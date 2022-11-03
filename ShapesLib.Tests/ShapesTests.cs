using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesLib.Tests;

[TestClass]
public class ShapesTests
{
    [TestMethod]
    public void CalcCircleArea()
    {
        const double radius = 10;
        const double expected = 314.1592;

        var circle = new Circle(radius);
        var actual = circle.CalcArea();

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [TestMethod]
    public void CalcTriangleArea()
    {
        const double a = 10;
        const double b = 14;
        const double c = 18;
        const double expected = 69.6491;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.CalcArea();

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [TestMethod]
    public void TriangleIsRectangular()
    {
        const double a = 6;
        const double b = 8;
        const double c = 10;
        const bool expected = true;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.IsRectangular();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TriangleIsNotRectangular()
    {
        const double a = 6;
        const double b = 8;
        const double c = 12;
        const bool expected = false;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.IsRectangular();

        Assert.AreEqual(expected, actual);
    }
}
using ShapesLib;

var shapes = new List<IShape> { new Circle(10), new Triangle(6, 8, 10), new Circle(2) };

foreach (var shape in shapes)
{
    Console.WriteLine(shape.CalcArea());
}
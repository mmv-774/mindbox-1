namespace ShapesLib;

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = new Size(radius);
    }

    private Size Radius { get; }

    public double CalcArea()
    {
        return Math.PI * Math.Pow(Radius.Value, 2);
    }
}
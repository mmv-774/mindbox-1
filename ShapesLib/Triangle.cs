namespace ShapesLib;

public class Triangle : IShape
{
    public Triangle(double a, double b, double c)
    {
        A = new Size(a);
        B = new Size(b);
        C = new Size(c);

        IsTriangle(a, b, c);
    }

    private Size A { get; }
    private Size B { get; }
    private Size C { get; }

    public double CalcArea()
    {
        var p = (A.Value + B.Value + C.Value) / 2;
        return Math.Sqrt(p * (p - A.Value) * (p - B.Value) * (p - C.Value));
    }

    public bool IsRectangular()
    {
        var powA = Math.Pow(A.Value, 2);
        var powB = Math.Pow(B.Value, 2);
        var powC = Math.Pow(C.Value, 2);

        return powA.Equals(powB + powC) || powB.Equals(powA + powC) || powC.Equals(powA + powB);
    }

    private static void IsTriangle(double a, double b, double c)
    {
        if (a > b + c || b > a + c || c > a + b)
            throw new Exception(
                "Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон");
    }
}
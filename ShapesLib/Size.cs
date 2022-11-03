namespace ShapesLib;

public class Size
{
    private readonly double _value;

    public Size(double value)
    {
        Value = value;
    }

    public double Value
    {
        get => _value;
        private init
        {
            if (value < 0) 
                throw new Exception("Размеры фигуры не могут быть меньше 0");
            _value = value;
        }
    }
}
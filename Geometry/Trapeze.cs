namespace Geometry;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public Trapeze(string name, double a, double b, double c, double d) : base(name, a, b, c)
    {
        D = d;
    }

    public override double GetArea() => ((A + B) / 2) * C;

    public override double GetPerimeter() => A + B + C + D;

    private double ValidateD(double d)
    {
        if (d <= 0)
            throw new Exception($"The side {d} is invalid.");
        return d;
    }
}

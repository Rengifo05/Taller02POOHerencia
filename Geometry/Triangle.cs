namespace Geometry;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public Triangle(string name, double a, double b, double c) : base(name, a, b)
    {
        C = c;
        H = 0; // opcional si se requiere en otras variantes
    }

    public override double GetArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public override double GetPerimeter() => A + B + C;

    private double ValidateC(double c)
    {
        if (c <= 0)
            throw new Exception($"The side {c} is invalid.");
        return c;
    }

    private double ValidateH(double h)
    {
        if (h < 0)
            throw new Exception($"The height {h} is invalid.");
        return h;
    }
}

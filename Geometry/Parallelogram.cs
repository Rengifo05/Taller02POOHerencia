namespace Geometry;

public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea() => A * H;
    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new Exception($"The height {h} is invalid.");
        return h;
    }
}

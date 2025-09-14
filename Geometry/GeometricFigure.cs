namespace Geometry;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    protected GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-12} => Area.....: {GetArea(),10:F6}   Perimeter: {GetPerimeter(),10:F5}";
    }
}

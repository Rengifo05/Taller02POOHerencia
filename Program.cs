using Geometry;

var circle = new Circle(nameof(Circle), 5);
var square = new Square(nameof(Square), 10);
var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
var kite = new Kite(nameof(Kite), 8, 7, 20, 30);
var rectangle = new Rectangle(nameof(Rectangle), 14.447563761223694, 57.91043623877631);
var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 86.16608873720136);
var triangle = new Triangle(nameof(Triangle), 27.30405, 42.0, 15.68595);
var trapeze = new Trapeze(nameof(Trapeze), 20, 20, 40, 20);

var figures = new List<GeometricFigure> { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}

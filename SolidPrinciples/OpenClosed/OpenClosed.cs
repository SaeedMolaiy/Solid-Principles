namespace SolidPrinciples.OpenClosed;

// Without OCP
internal class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

internal class AreaCalculator
{
    public double CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

// With OCP
internal interface IShape
{
    double Area();
}

internal class RectangleOcp : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

internal class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
using System;

// Abstract base class Shape
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(4.0);
        Rectangle rectangle = new Rectangle(5.0, 7.0);

        // Display their areas using string.Format
        Console.WriteLine("The area of the Circle is {0:F2}", circle.GetArea());
        Console.WriteLine("The area of the Rectangle is {0:F2}", rectangle.GetArea());
    }
}

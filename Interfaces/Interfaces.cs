using System;

// Define the IMovable interface
public interface IMovable
{
    void Move();
}

// Create the Car class that implements IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Create the Bicycle class that implements IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Car and Bicycle
        var car = new Car();
        var bicycle = new Bicycle();

        // Call the Move() method on each instance
        car.Move();
        bicycle.Move();
    }
}

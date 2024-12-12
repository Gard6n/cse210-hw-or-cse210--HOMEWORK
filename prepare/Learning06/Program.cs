using System;
using learning06;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(12,"Blue"));
        shapes.Add(new Rectangle(10,10,"Green"));
        shapes.Add(new Square(32,"Brown"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The Color: {shape.GetColor()}");
            Console.WriteLine($"The Area: {shape.GetArea()}\n");
        }
    }
}
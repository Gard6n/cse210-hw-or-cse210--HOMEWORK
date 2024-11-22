using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction math = new();
    
        Console.WriteLine("Enter in a numerator\n");
        int Numerator = int.Parse(Console.ReadLine());
        math.SetTop(Numerator);
        
        Console.WriteLine("Enter in a denominator\n");
        int Denominator = int.Parse(Console.ReadLine());
        math.SetBottom(Denominator);
        
        math.Fraction1();
        math.Fraction2();
        math.Fraction3();
        

    }
}
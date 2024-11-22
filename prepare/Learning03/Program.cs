using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction math = new();
    
        math.Fraction1();

        Console.WriteLine(math.GetBottom());
        
        Console.WriteLine("Enter in a numerator");
        int Numerator = int.Parse(Console.ReadLine());
        math.SetTop(Numerator);
        
        math.Fraction3();
        
        math.Fraction2();
        
        math.GetFractionString();

        math.GetDecimalValue();
        
        Console.WriteLine("Enter in a numerator");
        Numerator = int.Parse(Console.ReadLine());
        math.SetTop(Numerator);
        
        Console.WriteLine("Enter in a denominator");
        int Denominator = int.Parse(Console.ReadLine());
        math.SetBottom(Denominator);
        
        math.Fraction3();
        
        math.GetDecimalValue();
    
    }
}
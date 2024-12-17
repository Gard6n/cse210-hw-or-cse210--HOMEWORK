using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Running run = new(4,10);
        Console.WriteLine(run.GetSummary());
        Bicycles bike = new(50, 10);
        Console.WriteLine(bike.GetSummary());
        Swimming swim = new(400, 10);
        Console.WriteLine(swim.GetSummary());
    }
}
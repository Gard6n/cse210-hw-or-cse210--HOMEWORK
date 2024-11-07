using System;

class Program
{
    static void Main(string[] args)
    {
       string first; 
       string last; 

       Console.WriteLine("What is your first Name? ");
        first = Console.ReadLine();
        Console.WriteLine("What is your Last name?");
        last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
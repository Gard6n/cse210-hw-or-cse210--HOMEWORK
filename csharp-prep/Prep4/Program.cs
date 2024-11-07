using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      int yee = 0;
      int counter = 0;
      List<int> numbs = new List<int>();
      
      Console.WriteLine("Enter a list of numbers, Type 0 When done");

    // Writes to a list until user enters zero
     do { 
       Console.Write("Enter a number: ");
       string NUM = Console.ReadLine();
        yee = int.Parse(NUM);
        numbs.Add(yee);
        counter++;
     } while(yee > 0);

    int sum = numbs.Sum();
    double arv = numbs.Average();
    int max = numbs.Max();

    Console.WriteLine($"The sum is {sum}");
    Console.WriteLine($"The Aerage is {arv}");
    Console.WriteLine($"The largest number is {max}");
    }
}
 
using System;
using System.Collections.Generic;
using System.IO;

class Program{

static void Main(string[] args)
    {
        Journal_Entry JournalE1 = new Journal_Entry();

        while (JournalE1._input != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");

            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out JournalE1._input)) //Added error handling
            {
                Console.WriteLine();
                JournalE1.Number_Display();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }
    }
}
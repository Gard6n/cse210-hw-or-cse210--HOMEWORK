using System;

class Program
{
    static void Main(string[] args)
    {
    string Jobs_amount;
    Resume resume = new();
    Job jobs1 = new();    
    Console.WriteLine("How many jobs would you like to add? ");
    Jobs_amount = Console.ReadLine();
    int amount = int.Parse(Jobs_amount);

    Console.WriteLine("What is your Full Name? ");
        resume._name = Console.ReadLine();


    for (int i = 0; i < amount; i++){

        Console.WriteLine("What Company? ");
        jobs1._company = Console.ReadLine();

        Console.WriteLine("What kind of title? ");
        jobs1._jobTitle = Console.ReadLine();
        
        Console.WriteLine("What start year? ");
        string year = Console.ReadLine();
        jobs1._startYear = int.Parse(year);

        Console.WriteLine("What end year? ");
        string year2 = Console.ReadLine();
        jobs1._endYear = int.Parse(year2);
        
        resume._jobs.Add(jobs1);
        resume.Display();
    }
    

    }
}
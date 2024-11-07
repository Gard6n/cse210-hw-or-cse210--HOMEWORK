using System;

class Program
{
    static void Main(string[] args)
    {
       int Guess = 0;
       string guess = "";
       int counter = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine("Guess the number game!!!!");
        Console.WriteLine("Input a number to Guess");

        while (!(number == Guess)){

            guess = Console.ReadLine();
            Guess = int.Parse(guess);

            if (Guess < number){
                Console.WriteLine("Guess Higher!");
                counter++;
            }

            if (Guess > number){
                Console.WriteLine("Guess Lower!");
                counter++;
            }
        }
        
        counter++;
       Console.WriteLine($"YOU WIN, U GUESSED {counter} TIMES!");
    }
}  
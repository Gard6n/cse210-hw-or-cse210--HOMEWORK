using System;

class Program
{

    static void Main(string[] args)
    {
       string Grade;
       string grade ="";

       Console.WriteLine("Enter a Grade Percentage ");
       Grade = Console.ReadLine();
       int num = int.Parse(Grade);

       if (num >= 90 ){
        grade = "A";
       };

       if (num >= 80 && num < 90){
        grade = "B";
       }

       if (num >= 70 && num < 80){
        grade = "C";
       }

       if (num >= 60 && num < 70){
        grade = "D";
       } 

       if (num < 60){
        grade = "F";
       }
         Console.WriteLine($"Your Grade is {grade}");

       if (num >= 70){
          Console.WriteLine("You Pass!");
         }
       else{
          Console.WriteLine("You failed");
       } 
    }
}
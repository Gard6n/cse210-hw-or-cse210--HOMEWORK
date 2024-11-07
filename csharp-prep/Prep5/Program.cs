using System;

class Program
{
    static void Main(string[] args)
    {
       //Display opening
        static void DisplayMes(){
            Console.WriteLine("Welcome to the Program!");
        }
        //User Name
        static string Userinput(){
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //User Favorite Number
        static int UserNum(){
            Console.WriteLine("Please Enter your favoritee Number");
            string faa = Console.ReadLine();
            int fav = int.Parse(faa);
        //Squares the number
            int Fav = fav*fav;
            return Fav;
        }
        //Results
        static void Results(string na, int nee){
            Console.WriteLine($"{na}, the square of your is {nee}");
        }
        //Calling the methods
        DisplayMes();
        Results(Userinput(),UserNum());
    }
}
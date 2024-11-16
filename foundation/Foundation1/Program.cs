using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal_Entry JournalE1 = new Journal_Entry();
        Prompt Prompt_Gen = new();
        Entry entry = new();

        while (JournalE1._input != 5){
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please selcet one of the following choices: ");

            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do? ");
            string input = Console.ReadLine();
            JournalE1._input = int.Parse(input);
            Console.WriteLine();
             
             if (JournalE1._input ==  1){
                entry._promptText = Prompt_Gen.Prompt_Gen();
                Console.WriteLine(entry._promptText);
                entry._Entry = Console.ReadLine();
             }
          
             if (JournalE1._input == 2){

                JournalE1.Display_Journals();
             }   

             if (JournalE1._input == 3){


         
            }

            if (JournalE1._input == 4){



            }
        }    

    }
}
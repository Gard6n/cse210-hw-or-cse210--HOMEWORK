namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new("john",3,4);
        Scripture scripture = new(reff,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        
        Console.WriteLine("Welcome to Scripture Mastery");

        while (!scripture.IsCompetelyHidden())
        {
            
            
        }
        
   
       
       


    }
}
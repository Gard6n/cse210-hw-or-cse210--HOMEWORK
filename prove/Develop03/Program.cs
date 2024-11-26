namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new("john",3,4);
        Scripture scripture = new(reff,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Random rnd = new();
        List<int> numlist = new List<int>();
        for(int i = 0; i < 24; i++)
        {
           numlist.Add(i);
        }

        Console.WriteLine("Welcome to Scripture Mastery");

        while (!scripture.IsCompetelyHidden())
        {
            int rand = rnd.Next(numlist.Count);
            Console.WriteLine(reff.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.ReadLine();
            scripture.HideRandomWords(rand);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            numlist.Remove(rand);
            scripture.IsCompetelyHidden();
        }
        Console.WriteLine("Program Finished");
    }
}
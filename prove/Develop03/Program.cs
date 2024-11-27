namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new("john",3,4);
        Scripture scripture = new(reff,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Random rnd = new();
        
        List<int> numlist = new List<int>();
        for(int i = 0; i < scripture.GetNumberOfWords(); i++)
        {
           numlist.Add(i);
        }
        
        Console.WriteLine("Welcome to Scripture Mastery");
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompetelyHidden())
        {
            int rand = rnd.Next(0,numlist.Count);
            int temp = numlist[rand];
            Console.ReadLine();
            scripture.HideRandomWords(temp);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            numlist.Remove(temp);
            
            scripture.IsCompetelyHidden();
        }
        Console.WriteLine("Program Finished");
    }
}
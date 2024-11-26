namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new("john",3,4);
        Scripture scripture = new(reff,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Random rnd = new();
        List<int> numlist = new List<int>();
        foreach (var i in Enumerable.Range(1, 25))
        {
           numlist.Add(rnd.Next(i));
        }

        Console.WriteLine("Welcome to Scripture Mastery");

        while (!scripture.IsCompetelyHidden())
        {
            int rand = rnd.Next(numlist.Count);
            scripture.GetDisplayText();
            scripture.HideRandomWords(rand);
            scripture.GetDisplayText();
            numlist.RemoveAt(rand);
            
        }
        
   
       
       


    }
}
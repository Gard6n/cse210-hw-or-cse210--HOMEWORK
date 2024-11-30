namespace Foundation1;

class Program
{
    static void Main(string[] args)
    {
        //Presets for making videos -- This would be written differently if it was used in an project
        List<string> VidComs = new List<string>(){"Wow this video is so bad","GG I like this vid","Whens the next vid?"};
        List<string> ComsNames = new List<string>(){"Drake","John","Jack"};
        
        List<string> title = new List<string>(){"How to be ninja","Charlie the Unicorn","What to do Breath air"};
        List<string> author = new List<string>(){"Dj Big Mac","AppleLabs","Abe James"};
        List<int> videoLength = new List<int>(){3,6,4};
        
        Comment comment = new Comment();
        Video Vid = new(title, author, videoLength);
        Video Vid2 = new(VidComs, ComsNames);
        for (int i = 0; i < videoLength.Count; i++)
        {
            Console.WriteLine(Vid.Display(i));
        }
        
    }
}
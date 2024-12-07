namespace Develop05;

class Program
{
    static void Main(string[] args)
    {
        Activity act  = new Activity();
        bool programExit = false;
        while (!programExit == true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Chose a program to start");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Reflecting Activity -- Enter 1");
            Console.WriteLine("Breathing Activity -- Enter 2");
            Console.WriteLine("Listing Activity -- Enter 3");
            Console.WriteLine("-------------------------");
            Console.WriteLine("End Program -- Enter 5");
            string select = Console.ReadLine();
            int selectint = Convert.ToInt32(select);
            switch (selectint)
            {
                case 1:
                    Console.Clear();
                    ReflectingActivity reflect1 = new();
                    reflect1.Run();
                    break;
                case 2:
                    Console.Clear();
                    BreathingActivity breath1 = new();
                    breath1.Run();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity list1 = new();
                    list1.Run();
                    break;
                case 5:
                    programExit = true;
                    break;
            }
        }
    } 
}
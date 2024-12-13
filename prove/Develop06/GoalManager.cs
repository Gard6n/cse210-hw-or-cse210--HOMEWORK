namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        bool end = false;
        while (!end)
        {
            Display_Player_Info();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new Goal");
            Console.WriteLine("2. List a new Goal");
            Console.WriteLine("3. Save a Goals");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

           int choice = int.Parse(Console.ReadLine());

           switch (choice)
           {
               case 1:
                   break;
               case 2:
                   break;
               case 3:
                   break;
               case 4:
                   break;
               case 5:
                   break;
               case 6:
                   //Ends the program
                   Console.Clear();
                   Console.WriteLine("Goodbye!");
                   Thread.Sleep(200);
                   end = true;
                   break;
           }

        }
        
    }

    public void Display_Player_Info()
    {
        Console.WriteLine($"Player Current Score: {_score}\n");
    }

    public void List_Goal_Names()
    {
        foreach (Goal g in _goals)
        {
            //Console.WriteLine($"{}");
        }
        
    }

    public void List_Goal_Details()
    {
        
    }

    public void Create_Goal()
    {
        Console.WriteLine("The types fo Goals are: \n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. List Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("What type of Goal do you want to add? ");
        int goal_choose = int.Parse(Console.ReadLine());

    }

    public void Record_Events()
    {
        foreach (Goal G in _goals)
        { 
            G.isComplete();
        }
        
    }

    public void Save_Goal()
    {
        
    }

    public void Load_Goal()
    {
        
    }
}
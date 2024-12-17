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
            Console.WriteLine("2. List all Goals");
            Console.WriteLine("3. Save a Goal");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

           int choice = int.Parse(Console.ReadLine());

           switch (choice)
           {
               case 1:
                   Console.Clear();
                   Create_Goal();
                   break;
               case 2:
                   Console.Clear();
                   List_Goal_Details();
                   break;
               case 3:
                   Console.Clear();
                   Save_Goal();
                   break;
               case 4:
                   Console.Clear();
                   Load_Goal();
                   break;
               case 5:
                   Console.Clear();
                   Record_Events();
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
    
    public void List_Goal_Details()
    {
        int amount = 1;
        foreach (Goal g in _goals)
        {
            if (g.isComplete())
            {
                Console.Write($"[X] ");
            }
            else
            {
                Console.Write($"[ ] ");
            }
            Console.WriteLine($"{amount}.{g.GetShortName()}, {g.GetDetialsString()}");
            amount++;
        }
    }
    

    public void Create_Goal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are: \n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. List Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("What type of Goal do you want to add? ");
        int goal_choose = int.Parse(Console.ReadLine());
        switch (goal_choose)
        {
            case 1:
                Console.WriteLine("What is the name of the Goal?");
                string goal_name = Console.ReadLine();
                Console.WriteLine("Provide the Description of the Goal");
                string goal_description = Console.ReadLine();
                Console.WriteLine("How many points for this Goal?");
                int goal_points = int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(goal_name,goal_description,goal_points,false));
                break;
            case 2:
                Console.WriteLine("What is the name of the Goal?");
                string goal_name2 = Console.ReadLine();
                Console.WriteLine("Provide the Description of the Goal");
                string goal_description2 = Console.ReadLine();
                Console.WriteLine("How many points for this Goal?");
                int goal_points2 = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for the bonus?");
                int goal_amount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for completing this goal?");
                int goal_bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(goal_name2,goal_description2,goal_points2,false,goal_amount, goal_bonus,0));
                break;
            case 3:
                Console.WriteLine("What is the name of the Goal?");
                string goal_name3 = Console.ReadLine();
                Console.WriteLine("Provide the Description of the Goal");
                string goal_description3 = Console.ReadLine();
                Console.WriteLine("How many points for this Goal?");
                int goal_points3 = int.Parse(Console.ReadLine());
                _goals.Add(new EternalGoal(goal_name3,goal_description3,goal_points3));
                break;
        }
    }

    public void Record_Events()
    {
        Console.WriteLine("Enter the Goal you want to record?");
        int goal_choose = Int32.Parse(Console.ReadLine());
        if (goal_choose >= 1)
        {
            goal_choose--; 
        }
        Goal user_select = Enumerable.ElementAtOrDefault(_goals, goal_choose);
        user_select.RecordEvent();
        _score += user_select.GetPoints();
    }

    public void Save_Goal()
    {
        try
        {
            Console.WriteLine("Enter the name of the file.");
            string file_name = Console.ReadLine();
            using (StreamWriter inputFile = new StreamWriter(file_name))
            {
               inputFile.WriteLine($"{_score}");
                foreach (Goal g in _goals)
                {
                    inputFile.WriteLine(g.GetStringRepresentation());
                }
            }
            Console.WriteLine("Saved Successfully.");
        }
        catch
        {
            Console.WriteLine("Problem saving file.");
        }
    }

    public void Load_Goal()
    {
        try
        {
            Console.WriteLine("Enter the name of the file.");
            string file_name = Console.ReadLine();
            string path = Directory.GetCurrentDirectory();
            string file_path = Path.Combine(path, file_name);
            string[] readtext = File.ReadAllLines(file_name);
            string name_create = "";
            string goal_name = "";
            string goal_description = "";
            int Goal_points = 0;
            bool Goal_bool = false;
            
            foreach (var read in readtext)
            {
                string[] temp = read.Split(',');
                int anumber = temp.Length;
                if (anumber == 1)
                {
                    _score = Int32.Parse(temp[0]);
                }
                else
                {
                    name_create = temp[0];
                    goal_name = temp[1];
                    goal_description = temp[2];
                    Goal_points = Int32.Parse(temp[3]);
                    if (name_create == "SimpleGoal")
                    {
                        Goal_bool = bool.Parse(temp[4]);
                        _goals.Add(new SimpleGoal(goal_name,goal_description,Goal_points,Goal_bool));
                    }

                    if (name_create == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(goal_name,goal_description,Goal_points));
                    }

                    if (name_create == "ChecklistGoal")
                    {
                        Goal_bool = bool.Parse(temp[4]);
                        int goal_bonus = Int32.Parse(temp[5]);
                        int goal_target = Int32.Parse(temp[6]);
                        int goal_amount = Int32.Parse(temp[7]);
                        
                        _goals.Add(new ChecklistGoal(goal_name,goal_description,Goal_points,Goal_bool,goal_amount,goal_bonus,goal_amount));
                    }
                }
            }
            Console.WriteLine("Loaded Successfully.");
        }
        catch
        {
            Console.WriteLine("Problem reading file.");
        }
    }
}
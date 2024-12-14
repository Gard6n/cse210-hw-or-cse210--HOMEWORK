namespace Develop06;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations!! You have earned {GetPoints()} points!"); 
        Console.WriteLine($"You now have {GetPoints()} points!");
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetShortName()},{GetDetialsString()},{GetPoints()}";
    }

    public override void MakeGoal(bool complete, int points, string name, string description,string name_create)
    {
        if (name_create == "EternalGoal")
        {
            _points = points;
            _shortName = name;
            _description = description;
        }
       
    }
}
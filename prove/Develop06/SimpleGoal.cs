namespace Develop06;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool Complete) : base(name, description, points)
    {
        _isComplete = Complete;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations!! You have earned {GetPoints()} points!");
        Console.WriteLine($"You now have {GetPoints()} points!");
        _isComplete = true;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
       return $"SimpleGoal,{GetShortName()},{GetDetialsString()},{GetPoints()},{isComplete()}";
    }
}
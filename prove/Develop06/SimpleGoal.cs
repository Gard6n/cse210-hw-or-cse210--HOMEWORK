namespace Develop06;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
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
        throw new NotImplementedException();
    }
}
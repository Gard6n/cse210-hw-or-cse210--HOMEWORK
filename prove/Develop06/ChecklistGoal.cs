namespace Develop06;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isCompleted;

    public ChecklistGoal(string shortName, string description, int points,bool Complete, int target, int bonus,int amount) : base(shortName,
        description, points)
    {
        _target = target;
        _bonus = bonus;
        _isCompleted = Complete;
        _amountCompleted = amount;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You have earned {GetPoints()}");

        if (_amountCompleted == _target)
        {
            Console.WriteLine("You have completed the goal!");
            Console.WriteLine($"You completed {_target}/{_amountCompleted}!");
            Console.WriteLine($"You have earned {_bonus} bonus points!");
            _isCompleted = true;
        }
    }

    public override bool isComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return
            $"ChecklistGoal,{GetShortName()},{GetDetialsString()},{GetPoints()},{_isCompleted},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetDetialsString()
    {
        return $"{_description} -- Currently completed: {_target}/{_amountCompleted}";
    }

    public override int GetPoints()
    {
        int the_points = 0;
        if (_amountCompleted == _target)
        {
            the_points = _bonus;
        }

        if (_amountCompleted < _target)
        {
            the_points = _points;
        }

        return the_points;
    }
}
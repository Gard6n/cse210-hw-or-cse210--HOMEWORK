namespace Develop06;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool isComplete();
    public abstract string GetStringRepresentation();
    public abstract void MakeGoal(bool complete, int points, string name, string description,string name_create);
    public virtual string GetDetialsString()
    {
        return _description;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    }
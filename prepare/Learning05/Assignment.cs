namespace Learning05;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string StudentName()
    {
        return _studentName;
    }

    public string Topic()
    {
        return _topic;
    }

    public string GetSummery()
    {
        return $"{_studentName} - {_topic}";
    }
}
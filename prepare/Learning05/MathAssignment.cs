namespace Learning05;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string Name, string Topic, string TextbookSection, string Problems) : base(Name, Topic)
    {
        _textbookSection = TextbookSection;
        _problems = Problems;
    }

    public string GetSummary()
    {
        string name = StudentName();
        string topic = Topic();
        return $"{name} - {topic}\n";
    }

    public string GetHomeworklist()
    {
        return $"{_textbookSection} - {_problems}\n";
    }
}
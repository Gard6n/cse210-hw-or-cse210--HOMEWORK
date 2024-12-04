namespace Learning05;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studenName, string topic, string title) : base(studenName, topic)
    {
        _title = title;
    }
    
    public string GetWritingInfomation()
    {
        string name = StudentName();
        return $"{_title} - {name} ";
    }
}
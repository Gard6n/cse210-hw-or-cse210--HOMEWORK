namespace Foundation1;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment){
        _comment = comment;
        _name = name;
    }

    public string Display()
    {
        return _comment;
    }
}
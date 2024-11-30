namespace Foundation1;

public class Comment
{
    private string _name;
    private string _comment;
    private string _count;
    public Comment(string name, string comment){
        _name = name;
        _comment = comment;
    }

    public Comment()
    {
        _name = string.Empty;
        _comment = string.Empty;
    }

    public string Display()
    {
        int commentCount = 0;
        foreach (var word in _comment.Split(' '))
        {
            commentCount = word.Count();
        }
        _count = commentCount.ToString();
        return$"{_count}";
    }
}
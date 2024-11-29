namespace Foundation1;

public class Video
{
    Comment _com;
    private string _title;
    private string _author;
    private int _lengthsec;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _lengthsec = length;
    }

    public Video(Comment comc, string comments)
    {
        _com = comc;

        foreach(var com in comments){
            _comments.Add(Comment(com));

        }
    }

    public string Display(){

        return _comment.count;
    }

}
namespace Foundation1;

public class Video
{
    private Comment comment;
    private List<string> _title;
    private List<string> _author;
    private List<int> _lengthsec = new List<int>();
    private List<Comment> _comments = new List<Comment>();

    private int NumberIterate;

    public Video(List<string> title, List<string> author, List<int> length){
        _title = title;
        _author = author;
        for (int i = 0; i < length.Count; i++)
        {
            int newlength = 60*length[i];
            _lengthsec.Add(newlength);
        }
    }
    
    //This is a overload Method 
    public Video(List<string> comments, List<string> commentsNames)
    {
        var comname = commentsNames.Zip(comments, (n, w) => new { Name = n, Comments = w });
        foreach(var com in comname){
            _comments.Add(new Comment(com.Name, com.Comments));
        } 
    }

   public string Display(int Amount)
   {
       NumberIterate = Amount;
    
       return $"Video title: {_title[NumberIterate] + " " + "Author: " + _author[NumberIterate]}" +
              $"Video Length in seconds: {_lengthsec[NumberIterate] + " " + _comments[NumberIterate]}";
   }
}

namespace Foundation1;

public class Video
{
    private Comment thecomment;
    private List<string> _title;
    private List<string> _author;
    private List<int> _lengthsec = new List<int>();
    private List<string> _comments;

    private int NumberIterate;

    public Video(Comment com, List<string> title, List<string> author, List<int> length){
        _title = title;
        _author = author;
        thecomment = com;
        _comments = thecomment.Transfer();
        for (int i = 0; i < length.Count; i++)
        {
            int newlength = 60*length[i];
            _lengthsec.Add(newlength);
        }
    }
    
   public string Display(int Amount)
   {
       
       NumberIterate = Amount;
       return $"Video title: {_title[NumberIterate] + " " + "Author: " + _author[NumberIterate]} " +
              $"Video Length in seconds: {_lengthsec[NumberIterate]}\n";
   }
}

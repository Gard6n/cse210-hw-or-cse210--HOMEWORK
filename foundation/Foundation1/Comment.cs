namespace Foundation1;

public class Comment
{
  
    private List<string> _name;
    private List<string> _comment;
    private int _amount;
    

    public Comment(List<string> comment, List<string> name){
       _name = name;
      _comment = comment;
    }

    public List<string> Transfer()
    {
    
        return _comment;
    }
    
    public string Display(int NumberIterate)
    {
        _amount = NumberIterate;
        return $"Comment Name:{_name[_amount] + " -- " + _comment[_amount]}\n";
    }
}
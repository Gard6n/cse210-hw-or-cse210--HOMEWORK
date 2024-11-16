
public class Entry
{

public string _Entry;
public DateTime _Current_date = DateTime.Now;
public string  _promptText;

public void Display(){

Console.WriteLine($"{_Current_date} - Prompt -- {_promptText}");
Console.WriteLine(_Entry);

}
}   
public class Resume
{

public string _name = "";
public List<Job> _jobs = new List<Job> ();

public void Display(){

Console.WriteLine($"{_name}");
Console.WriteLine($"Jobs: ");

foreach (Job jobs1 in _jobs){
    jobs1.Display();
}

}

}
namespace Develop05;

public class ListingActivity : Activity
{
private int _count;
private List<string> _prompts;
private List<string> _listofprompts = new List<string>();
	
public ListingActivity()
{
	_name = "Listing Activity";
	_description = "This Activity will help you relfect on the good things in your life";
	_prompts = new List<string>()
	{
		"Who are people that you appreciate?",
		"What are personal strengths of yours?",
		"Who are people that you have helped this week?",
		"When have you felt the Holy Ghost this month?"
	};
}
	// This is the meat and bones that the user sees 
public void Run()
{
	Console.WriteLine($"Welcome to the {_name}!");
	DisplayStartingMessage();
	Console.WriteLine("Enter how how long in seconds would you like your session to be");
	int time = Convert.ToInt32(Console.ReadLine());
	DurationSet(time);
	Console.Clear();
	Console.WriteLine("Get Ready...");
	ShowSpinner(8);
	GetRandomPrompt();
	Console.WriteLine("You may begin in: ");
	ShowCountDown(5);
	GetListFromUser();
	Console.WriteLine($"You listed {_count} items!");
	DisplayEndingMessage();
	ShowSpinner(4);
	Console.WriteLine($"You have completed another {_duration} seconds of the Listing Activity");
	ShowSpinner(8);
}
	
public void GetRandomPrompt()
{
	Random Ra = new();
	if (_listofprompts.Count == 0)
	{
		for (int i = 0; i < _prompts.Count; i++)
		{
			_listofprompts.Add(_prompts[i]);
		}
	}
	int randomIndex = Ra.Next(0, _listofprompts.Count);
	int carryovernumber = randomIndex;
	// Makes sure not to give the same prompt
	_listofprompts.RemoveAt(randomIndex);
	// ---------------------------------
	string prompt = _prompts[carryovernumber];
	Console.WriteLine("List as many responses you can to the following prompt:");
	Console.WriteLine($"--- {prompt} ---");
	Thread.Sleep(500);
}
	
public List<string> GetListFromUser()
{
	DateTime startTime = DateTime.Now;
	DateTime EndTime = startTime.AddSeconds(_duration);
	List<string> Userlist = new();

	while (DateTime.Now < EndTime)
	{
		Userlist.Add(Console.ReadLine());
		_count += 1;
	}
	// Not sure why this method needs to be a list? But it is because the HW said it needs to be
	return Userlist;
}
}
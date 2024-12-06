namespace Develop05;

public class ListingActivity : Activity
{
private int _count;
private List<string> _prompts;
	
public ListingActivity()
{
	_description = "This Activity will help you relfect on the good things in your life";
	_prompts = new List<string>()
	{
		"Who are people that you appreciate?",
		"What are personal strengths of yours?",
		"Who are people that you have helped this week?",
		"When have you felt the Holy Ghost this month?"
	};
}
	
public void Run()
{
	
}
	
public void GetRandomPrompt()
{
	Random Ra = new();
	List<string> listofprompts = new List<string>();
	for (int i = 0; i < _prompts.Count; i++)
	{
		listofprompts.Add(_prompts[i]);
	}
	int randomIndex = Ra.Next(0, listofprompts.Count);
	int carryovernumber = randomIndex;
	// Makes sure not to give the same prompt
	listofprompts.RemoveAt(randomIndex);
	// ---------------------------------
	string prompt = _prompts[carryovernumber];
	Console.WriteLine(prompt);
}
	
public List<string> GetListFromUser()
{
	
}
}
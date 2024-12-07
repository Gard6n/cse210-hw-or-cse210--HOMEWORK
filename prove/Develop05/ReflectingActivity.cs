namespace Develop05;

public class ReflectingActivity : Activity
{
private List<string> _prompts;
private List<string> _listofprompts = new List<string>();
private List<string> _question;
private List<string> _listofquestions = new List<string>();

	// Calling this Constructor will initialze the variables in the class Activity
public ReflectingActivity() 
{
	_name = "ReflectingActivity";
	_description = "This Activity will help you reflect on times in your life";
	_prompts = new List<string>()
	{
		"Think of a time when you stood up for someone else",
		"Think of a time when you did something really difficult.",
		"Think of a time when you helped someone in need.",
		"Think of a time when you did something truly selfless."
	};
	_question = new List<string>()
	{
		"What made this time different than other times when you were not as successful?",
		"What is your favorite thing about this experience?",
		"How can you keep this experience in mind in the future?",
		"Why was this experience meaningful to you?"
	};
}
	
public void Run()
{
	Console.WriteLine($"Welcome to the {_name}!");
	DisplayStartingMessage();
	Console.WriteLine();
	Console.WriteLine("Enter How how long in seconds would you like to reflect");
	int time = Convert.ToInt32(Console.ReadLine());
	DurationSet(time);
	Console.Clear();
	Console.WriteLine("Get Ready...");
	ShowSpinner(8);
	DisplayPrompt();
	Console.ReadLine();
	Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
	Console.WriteLine("You may begin in: ");
	ShowCountDown(5);
	DisplayQuestion();
	DisplayEndingMessage();
	Console.WriteLine($"You have completed another {_duration} seconds of the Reflecting Activity.");
	ShowSpinner(8);
}
	
public string GetRandomPrompt()
{
	Random Ra = new();
	if (_listofquestions.Count == 0)
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
	return prompt;
}
	
public string GetRandomQuestion()
{
	Random Ra = new();
	if (_listofprompts.Count == 0)
	{
		for (int i = 0; i < _question.Count; i++)
		{
			_listofquestions.Add(_question[i]);
		}
	}
	int randomIndex = Ra.Next(0, _listofquestions.Count);
	int carryovernumber = randomIndex;
	// Makes sure not to give the same question
	_listofquestions.RemoveAt(randomIndex);
	// ---------------------------------
	string question = _question[carryovernumber];
	return question;
}
	
public void DisplayPrompt()
{
	Console.WriteLine("Consider the following prompts:");
	Console.WriteLine($"--- {GetRandomPrompt()} ---");
	Console.WriteLine("When you have something in mind, press the enter to continue");
}
	
public void DisplayQuestion()
{
	Console.Clear();
	Console.WriteLine(GetRandomQuestion());
	ShowSpinner(_duration);
	Console.WriteLine(GetRandomQuestion());
	ShowSpinner(_duration);
}
}
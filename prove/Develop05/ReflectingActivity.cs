namespace Develop05;

public class ReflectingActivity : Activity
{
private List<string> _prompts;
private List<string> _question;

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
	
}
	
public string GetRandomPrompt()
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
	return prompt;
}
	
public string GetRandomQuestion()
{
	Random Ra = new();
	List<string> listofquestions = new List<string>();
	for (int i = 0; i < _question.Count; i++)
	{
		listofquestions.Add(_question[i]);
	}
	int randomIndex = Ra.Next(0, listofquestions.Count);
	int carryovernumber = randomIndex;
	// Makes sure not to give the same question
	listofquestions.RemoveAt(randomIndex);
	// ---------------------------------
	string question = _prompts[carryovernumber];
	return question;
}
	
public void DisplayPrompt()
{
	Console.WriteLine(GetRandomPrompt());
}
	
public void DisplayQuestion()
{
	Console.WriteLine(GetRandomQuestion());
}
}
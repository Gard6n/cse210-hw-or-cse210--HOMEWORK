namespace Develop05;

public class Activity
{
	// This code is using protected variables to make using the classes and methods easier with less code
protected string _name;
protected string _description;
private int _duration;

	// If this constructor is ever called it will return defualt values
public Activity()
{
	_name = "";
	_description = "";
	_duration = 0;
}

public void DurationSet(int duration)
{
	_duration = duration;
}
	
public void DisplayStartingMessage()
{
	Console.WriteLine(_description);
}
	
public void DisplayEndingMessage()
{
	Console.WriteLine("Good Job!!");
	
}
	
public void ShowSpinner(int seconds)
{
	DateTime startTime = DateTime.Now;
	DateTime endTime = startTime.AddSeconds(seconds);
	List<string> amimation = new List<string>()
	{
		"|",
		"/",
		"-",
		"\\",
		"|",
		"/",
		"-",
		"\\"
	};
	
	int Number = 0;
	while (DateTime.Now < endTime)
	{
		string show = amimation[Number];
		Console.WriteLine(show);
		Thread.Sleep(1000);
		Number++;
		if (Number > amimation.Count)
		{
			Number = 0;
		}
	}
}

public void ShowCountDown(int seconds)
{
	for (int i = seconds; i > 0; i--)
	{
		Console.WriteLine(i);
		Thread.Sleep(1000);
		if (seconds >= 10)
		{
			Console.WriteLine("\b\b\b");
		}
		else
		{
			Console.WriteLine("\b \b");
		}
	}
}
}
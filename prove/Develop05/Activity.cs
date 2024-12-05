namespace Develop05;

public class Activity
{
	// This code is using protected variables to make using the classes and methods easier with less code
protected string _name;
protected string _description;
protected int _duration;

	// If this constructor is ever called it will return defualt values
public Activity()
{
	_name = "";
	_description = "";
	_duration = 0;
}
	
public void DisplayStartingMessage()
{
	Console.WriteLine(_description);
	
}
	
public void DisplayEndingMessage()
{
	
}
	
public void ShowSpinner(int seconds)
{
	
}

public void ShowCountDown(int seconds)
{
	
}

}
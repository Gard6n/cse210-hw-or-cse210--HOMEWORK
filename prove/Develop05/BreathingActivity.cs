namespace Develop05;

public class BreathingActivity : Activity
{
	
public BreathingActivity()
{
	_name = "Breathing Activity";
	_description = "This activity will help you relax by walking your through breathing in and out slowly.";
}
	
public void Run()
{
	Console.WriteLine($"Welcome to the {_name}!");
	DisplayStartingMessage();
	Console.WriteLine("Enter how how long in seconds would you like your session to be");
	int time = Convert.ToInt32(Console.ReadLine());
	DurationSet(time);
	Console.Clear();
	Console.WriteLine("Get Ready...");
	ShowSpinner(5);
	DateTime startTime = DateTime.Now;
	DateTime endTime = startTime.AddSeconds(_duration);
	while(DateTime.Now < endTime)
	{
		Console.WriteLine("\n");
		Console.Write("Breathe in...");
		ShowCountDown(5);
		Console.WriteLine();
		Console.Write("Now breathe out...");
		ShowCountDown(5);
	}
	Console.WriteLine("\n");
	DisplayEndingMessage();
	ShowSpinner(4);
	Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
	ShowSpinner(8);
}

}
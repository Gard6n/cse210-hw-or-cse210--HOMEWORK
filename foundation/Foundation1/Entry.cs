
public class Entry
{
    public Prompt _prompt = new();
    public string _Entry;
    public DateTime _Current_date = DateTime.Now;
    public string _filePath; // Add a filepath for saving and loading


    public void Display_entry(int input, string filePath = "")
    {
        if (input == 2)
        {
            //Load from file if filepath is provided.  Otherwise, show existing _Entry.
            if (!string.IsNullOrEmpty(filePath))
            {
                if (File.Exists(filePath))
                {
                    _Entry = File.ReadAllText(filePath);
                    Console.WriteLine(_Entry);
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else
            {
                Console.WriteLine(_Entry);
            }
           
        }
        else if (input == 1)
        {
            string datetext = _Current_date.ToShortDateString();
            _Entry = datetext + " - " + "Prompt: " + _prompt.Prompt_Gen() + Environment.NewLine; //Added newline for better formatting
            Console.WriteLine(_Entry);
            _Entry += Console.ReadLine(); //Append user input to existing _Entry
        }
    }
}
public class Prompt
{
    public List<string> _Display_Prompt = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "Write about a place that is important to you.",
        "The most interesting thing I've learned this year is…",
        "What has someone taught you that you will never forget?",
        "If you had a superpower, what would it be and why?"
    };

    public string Prompt_Gen()
    {
        Random random = new Random(); // Create a new instance of Random each time.
        int NewPrompt = random.Next(_Display_Prompt.Count);
        return _Display_Prompt[NewPrompt];
    }
}
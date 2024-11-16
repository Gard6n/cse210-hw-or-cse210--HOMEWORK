public class Prompt{

public List<string> _Display_Prompt = new(){
"Who was the most interesting person I interacted with today?",
"Write about a place that is important to you.",
"The most interesting thing Ive learned this year is…",
"What has someone taught you that you will never forget?",
"If you had a superpower, what would it be and why?"
};



public  String Prompt_Gen(){

int NewPrompt = new Random().Next(_Display_Prompt.Count);

 return _Display_Prompt[NewPrompt];

}

}
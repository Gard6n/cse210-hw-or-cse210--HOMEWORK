namespace Develop03;

public class Scripture
{
    private Reference _reference{get;set;}
    private List<Word> _words = new List<Word>();

    public Scripture(Reference refer, string text){
        _reference = refer;
        string[] words = text.Split(' ');

        foreach (var word1 in words)
        {
            _words.Add(new Word(word1));
        }
            
    }

    public void HideRandomWords(int numberToHide){


    }

    public string GetDisplayText()
    {

        return "";
    }

    public bool IsCompetelyHidden()
    {
        bool hidden = true;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                hidden = false;
                break;
            }
        }
        return hidden;
    }
}
namespace Develop03;

public class Scripture
{
    private Reference _reference;
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
        
      if (numberToHide <= _words.Count)
      {
          _words[numberToHide].Hide();
      }
    }

    public string GetDisplayText()
    {
        string fulltext = _reference.GetDisplayText();
        foreach (var word in _words)
        {
             fulltext += " " + String.Concat(word.GetDisplaytext());
        }
        return fulltext;
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

    public int GetNumberOfWords()
    {
        return _words.Count;
    }
}
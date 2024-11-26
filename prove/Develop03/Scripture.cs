﻿namespace Develop03;

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
        string text = "";
        foreach (var word in _words)
        {
             text = String.Concat(word.GetDisplaytext());
        }
        text = text.Trim();
        return text;
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
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Develop03;

public class Reference
{
    private string _book{get;set;}
    private int _chapter{get;set;}
    private int _verse {get;set;}
    private int _endVerse{get;set;}
    
    
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else 
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    //This is put first in program.cs to declare the variables
    public void Getter()
    {
        //defaults 
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = -1;
    }

    public void Setter(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    
}
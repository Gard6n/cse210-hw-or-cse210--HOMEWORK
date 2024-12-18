﻿using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Develop03;

public class Reference
{
    private string _book{get;set;}
    private int _chapter{get;set;}
    private int _verse {get;set;}
    private int _endVerse{get;set;}
    
   
    public Reference(string book, int chapter, int startVerse, int endVerse = -1){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
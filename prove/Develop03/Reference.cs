using System.Globalization;
using CsvHelper;

namespace Develop03;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse ;
    private int _endVerse;
    private string _csvpath;
    
    
    
    public void BibleLoad()
    {
        try
        {
            if (File.Exists(_csvpath))
            {
                using (var reader = new StreamReader(_csvpath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecord<Reference>();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
    }

    public void Reference1(string book, int chapter, int verse){

    }

    public void Reference2(string book, int chapter, int startVerse, int endVerse){

    }

    public string GetDisplayText(){

        return "";
    }

    //This is put first in program.cs to declare the variables
    public void Getter()
    {
        //defaults 
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
        _csvpath = Path.Combine(Environment.CurrentDirectory, "kjv.csv");
    }
    
}
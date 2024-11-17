public class Journal_Entry
{
    public Entry _entry = new Entry();
    public List<string> _journals = new List<string>();
    public int _input = 0;


    public void Number_Display()
    {
        if (_input == 1)
        {
            _entry.Display_entry(_input);
        }
        else if (_input == 2)
        {
            _entry.Display_entry(_input);
        }
        else if (_input == 3)
        {
            LoadJournal();
        }
        else if (_input == 4)
        {
            SaveJournal();
        }
    }


    public void SaveJournal()
    {
        Console.WriteLine("Enter file path to save (e.g., journal.txt):");
        string filePath = Console.ReadLine();
        _entry._filePath = filePath; //Store the file path in the entry object
        try
        {
            File.WriteAllText(filePath, _entry._Entry);
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("Enter file path to load (e.g., journal.txt):");
        string filePath = Console.ReadLine();
        _entry.Display_entry(2, filePath);
    }
}
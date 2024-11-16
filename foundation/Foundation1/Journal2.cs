public class Journal_Entry
{  
public Entry entry = new();
public List<Entry> _journals = new();
public int _input = 0;


public void EntryAdd(){

//_journals.Add()

}

public void Display_Journals(){

foreach (Entry entry in _journals){
   entry.Display();
}

}
public void Saving_Journal(){


}

public void loading_Journal(){


}



}
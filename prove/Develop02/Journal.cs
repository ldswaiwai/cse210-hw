using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void Display()
    {
        
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter (file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.Display());
            }
        }   
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}

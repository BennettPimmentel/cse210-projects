using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.GetFormattedEntry());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2]));
            }
        }
    }
}
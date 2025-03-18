using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} | {_promptText} | {_entryText}");
    }

    public string GetFormattedEntry()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }
}
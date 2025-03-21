using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public void HideWords()
    {
        var availableWords = _words.Where(w => !w.IsHidden).ToList();
        int wordsToHide = Math.Min(3, availableWords.Count);
        
        foreach (var word in availableWords.OrderBy(_ => _random.Next()).Take(wordsToHide))
        {
            word.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}

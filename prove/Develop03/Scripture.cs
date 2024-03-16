using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = scriptureText.Split(new[] {' ','\n','\r'}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    
    }

    public Reference Reference
    {
        get {return _reference;}
    }

    public List<Word> Words
    {
        get {return _words;}
    }
    
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public void HideRandomwords()
    {
        Random random = new Random();
        int numberToHide = random.Next(1, _words.Count / 2);
        for  (int i = 0; i< numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            if(!_words[index].IsHidden)
            {
                _words[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
       string referenceString = _reference.GetDisplayText();
       string wordsString = string.Join(" ", _words.Select(word => word.GetDisplayText()));
       return $"{referenceString}: {wordsString}";
    }
}

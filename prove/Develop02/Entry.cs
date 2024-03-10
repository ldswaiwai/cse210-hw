public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        return $"Date: {_date} - Prompt: {_promptText} Your Response: {_entryText}";
    }
}
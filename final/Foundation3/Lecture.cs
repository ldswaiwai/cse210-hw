using System.ComponentModel;
using System.Reflection;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateFullDetails() + $"Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
    }

    public override string GenerateShortDecscription()
    {
        return $"Type of Event: Lecture\nEvent Title: {_title}\nDate: {_date}\n";
    }

}
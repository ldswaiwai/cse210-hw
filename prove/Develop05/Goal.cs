using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string ShortName => _shortName;
    public string Description => _description;
    public string Points => _points;

    public abstract void RecordEvent(string points);

    public abstract bool IsComplete();

    public virtual void GetDetailsString()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();
    }

    public abstract string GetStringRepresentation();


}
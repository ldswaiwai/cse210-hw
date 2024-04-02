public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public int AmountCompleted => _amountCompleted;
    public int Target => _target;
    public int Bonus => _bonus;


    public override void RecordEvent(string points)
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override void GetDetailsString()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})--Currently Completed-{_amountCompleted}/{_target}";
    }


}
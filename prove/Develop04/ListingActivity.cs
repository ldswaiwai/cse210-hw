using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity(string name, string description) : base(name, description, 0)
    {
        _name = "Listing";
        _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[index]}");
    }

    public List<string> GetListFromUser()
    {
        List<string> userInputList = new List<string>();
        
        string input;
        DateTime startTime = DateTime.Now;
        while((DateTime.Now - startTime).TotalSeconds < _duration && !string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            userInputList.Add(input);
        }
        return userInputList;
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the followig prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in : ");
        ShowCountDown(5);
        Console.WriteLine("");
        
        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now<endTime)
        {  
            userResponses.AddRange(GetListFromUser());
        }

        _count = userResponses.Count;
        Console.WriteLine($"You listed {_count} items!");

        base.DisplayEndingMessage();
    }
}

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public int GetDuration()
    {
        return _duration;
    }
    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\nThis activity will help you {_description}.");
        Console.Write($"\nHow long, in second, would you like for your session?");

        string input = Console.ReadLine();
        //Parse the input to convert it into an integer
        if(int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            //retry obtaining valid input
            DisplayStartingMessage();
            return;
        }
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(5);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
    }

    public void ShowSpinner(int second)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);

        int i = 0;
        while(DateTime.Now<endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i>=animationStrings.Count)
            {
                i=0;
            }
        }

    }

    public void ShowCountDown(int seconds)
        {
            for (int i=seconds; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    

}

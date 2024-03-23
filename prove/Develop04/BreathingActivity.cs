public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description): base(name, description, 0)
    {
        _name = "Breathing";
        _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


    public void Run()
    {
        
        base.DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now<endTime)
        {
            Console.Write("\nBreath in...");
            base.ShowCountDown(5);
            Console.Write("\nBreath out...");
            base.ShowCountDown(5);
        }

        base.DisplayEndingMessage();
    }

}


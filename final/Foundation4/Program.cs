using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("05 Apr 2024", 30, 3.0));
        activities.Add(new Cycling("06 Apr 2024", 45, 15.0));
        activities.Add(new Swimming("07 Apr 2024", 60, 10));
    

        foreach (var activity in activities)
        {
           Console.WriteLine(activity.GetSummary()); 
        }

    }    

}
using System;
//To exceed the requirements 
//I have added the code to handle with the invalid input from user
//also, I have added a code in the ListingActivity class 
//so the user can complete the whole sentence even when it reaches the time limit
class Program
{
    static void Main(string[] args)
    {
        string userInput;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Start breathing activity \n2. Start reflecting activity \n3. Start Listing activity \n4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if(userInput =="1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathing.Run();
            }
            else if(userInput =="2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                reflecting.Run();
            }
            else if(userInput =="3")
            {
                ListingActivity listing = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area");
                listing.Run();
            }
            else if (userInput =="4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for participating the activity. Visit again next time, goodbye!");
                Console.WriteLine("");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }

        }
    }
}

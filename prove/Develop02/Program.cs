using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string userChoice =""; 
        while (userChoice != "5") 
        { 
            Console.Write("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit\nWhat would you like to do? ");
            userChoice = Console.ReadLine(); 
        
            if (userChoice =="1")
            {
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                PromptGenerator prompt = new PromptGenerator();
                newEntry._date = theCurrentTime.ToShortDateString();
                newEntry._promptText = prompt.GetRandomPrompt();
                newEntry._entryText = Console.ReadLine();
                Journal myJournal = new Journal();
                myJournal.AddEntry(newEntry);
            }

            else if (userChoice =="2")
            {
                Journal newJournal = new Journal();
                newJournal.Display();
            }

            else if (userChoice =="3")
            {
                Console.WriteLine("What is the filename?");
                String file = Console.ReadLine();
                Journal newJournal = new Journal();
                newJournal.LoadFromFile(file);
            }
        
            else if (userChoice =="4")
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                Journal newJournal = new Journal();
                newJournal.SaveToFile(file);
                Console.WriteLine("Your entry has been saved successfully!");
            }
        }
    }
}
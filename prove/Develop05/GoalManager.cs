using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score=0;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        string userInput = "";
        while (userInput != "6")
        {
            Console.WriteLine($"{DisplayPlayerInfo()}");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \n");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }
        }
    }

    public string DisplayPlayerInfo()
    {
        return $"You have {_score} points.\n";
    }

    public void ListGoalName()
    {
        Console.WriteLine("List of Goals: ");
        for (int i = 0; i< _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].ShortName}");
        }

    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        string userInput = "";
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal ");
        Console.Write("Which type of goal would you like to create? ");
        userInput = Console.ReadLine();

        if (userInput == "1")
        {
            bool isComplete = false;
            Goal goal = new SimpleGoal("","","", isComplete); 
            goal.GetDetailsString();
            _goals.Add(goal);
        }

        else if (userInput == "2")
        {
            Goal goal = new EternalGoal("","","");
            goal.GetDetailsString();
            _goals.Add(goal);
        }

        else if (userInput == "3")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal("","","", 0, 0, 0);
            checklistGoal.GetDetailsString();
            _goals.Add(checklistGoal);
        }

        else 
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
            CreateGoal();
        }

    }

    public void RecordEvent()
    {
        ListGoalName();
        
        Console.Write("Which goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index<=0 || index> _goals.Count)
        {
            Console.WriteLine("Invalid goal index. Please enter a valid index from the list");
            return;
        }
        
        Goal goal = _goals[index-1];
        goal.RecordEvent(goal.Points);

        _score += int.Parse(goal.Points);

        Console.WriteLine($"You have earned {goal.Points} points!\n");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string totalScoreString = DisplayPlayerInfo();

            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    outputFile.WriteLine($"{goal.ShortName}, {goal.Description}, {goal.Points}, {simpleGoal.IsComplete} ");
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"{goal.ShortName}, {goal.Description}, {goal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"{goal.ShortName}, {goal.Description}, {goal.Points}, {checklistGoal.AmountCompleted}, {checklistGoal.Target}, {checklistGoal.Bonus}");
                }
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals from: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            using(StreamReader inputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {                    
                    string[] parts = line.Split(',');
                    
                    if (parts.Length >= 3
                    )
                    {
                        string name = parts[0].Trim();
                        string description = parts[1].Trim();
                        string points = parts[2].Trim();
                        
                        Goal goal = null;

                        if (parts.Length ==6)
                        {
                            if (int.TryParse(parts[3], out int amountCompleted) &&
                                int.TryParse(parts[4], out int target) &&
                                int.TryParse(parts[5], out int bonus))
                            {    
                                goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                            }
                            else
                            {
                                Console.WriteLine("Invalid data format for ChecklistGoal");
                            }
                        }
                        else if (parts.Length == 4)
                        {
                        
                            if (bool.TryParse(parts[3], out bool isComplete))
                            {
                                goal = new SimpleGoal(name, description, points, isComplete);
                            }
                            else
                            {
                                Console.WriteLine("Invalid data format for boolean value. ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data format.");
                        }
                        
                        if(goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient data in line.");
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }         
        else
        {
            Console.WriteLine("File not found.");
        }

    }


}
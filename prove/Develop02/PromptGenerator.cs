using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    
    public string GetRandomPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        return prompt;
    }
}
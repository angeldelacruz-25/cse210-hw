
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _answers;
    private Random _random;

    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _random = new Random();
        _answers = new List<string>();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What miracle did you see this week?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items:");

        _answers.Clear();

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(answer))
            {
                _answers.Add(answer);
            }

            if ((DateTime.Now - startTime).TotalSeconds >= GetDuration())
                break;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_answers.Count} items.");
        
        DisplayEndingMessage();
    }
}

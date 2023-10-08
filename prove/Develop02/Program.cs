using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        prompt.Prompts.Add("What have I done today that I can be proud of?");
        prompt.Prompts.Add("How did I see God's hand in my life today?");
        prompt.Prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt.Prompts.Add("Who was the most interesting person I interacted with today?");
        prompt.Prompts.Add("What was the strongest emotion I felt today?");

        Console.WriteLine("Welcome to your journal!");
        (journal.FirstName,journal.LastName) = Program.SignIn();

        Console.WriteLine($"Hello {journal.FirstName} {journal.LastName}!");

        while (true)
        {
            Menu(journal,prompt);
        }
    }

    static (string, string) SignIn()
    {
        Console.WriteLine("Please enter your name:");
        Console.WriteLine("First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Last Name:");
        string lastName = Console.ReadLine();

        return (firstName, lastName);
    }

    static void Menu(Journal journal,Prompt prompt)
    {
        Console.WriteLine("---| Menu |---");
        Console.WriteLine("1. New Entry");
        Console.WriteLine("2. View Journal");
        Console.WriteLine("3. New Prompt");
        Console.WriteLine("4. View Prompts");
        Console.WriteLine("5. Switch User");
        Console.WriteLine("6. Quit");

        string choice = Console.ReadLine();
        
        if (choice == "1")
        {
            journal.WriteNew(prompt);
        }
        else if (choice == "2")
        {
            journal.DisplayEntries();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Please enter the prompt:");
            prompt.Prompts.Add(Console.ReadLine());
            Console.Write("Prompt added!");
        }
        else if (choice == "4")
        {
            prompt.View();
        }
        else if (choice == "5")
        {
            SignIn();
        }
        else if (choice == "6")
        {
            Console.WriteLine("Thanks for using!");
            Environment.Exit(0);
        }
    }
}
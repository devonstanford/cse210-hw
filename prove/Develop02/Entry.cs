using System;

public class Entry
{
    public string Date { get; set; }

    public string Prompt { get; set; }

    public string Response { get; set; }

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine(Date);
        Console.WriteLine("");
        Console.WriteLine(Prompt);
        Console.WriteLine("");
        Console.WriteLine(Response);
    }
}
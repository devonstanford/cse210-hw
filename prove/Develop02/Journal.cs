using System;
using System.Globalization;

public class Journal
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public List<Entry> Entries { get; set; }

    public Journal()
    {
    }

    public void WriteNew(Prompt prompt)
    {
        Entry entry = new Entry();

        entry.Prompt = prompt.Get();
        Console.WriteLine($"Please answer this prompt: {entry.Prompt}");
        entry.Response = Console.ReadLine();

        entry.Date = DateTime.Now.ToString();

        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {

    }

    public void Load()
    {

    }
}
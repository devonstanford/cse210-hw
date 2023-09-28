using System;

public class Resume
{
    public string Name { get; set; }

    public List<Job> Jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Work Experience:");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}
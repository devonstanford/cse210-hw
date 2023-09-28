using System;

public class Resume
{
    public string Name { get; set; }

    public List<Job> Jobs { get; set; }

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}
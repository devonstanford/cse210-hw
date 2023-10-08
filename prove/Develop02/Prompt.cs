using System;

public class Prompt
{
    public List<string> Prompts { get; set; }

    public Prompt()
    {
    }

    public string Get()
    {
        Random rand = new Random();
        return Prompts[rand.Next(0,Prompts.Count-1)];
    }

    public void View()
    {
        int i = 1;
        foreach(String prompt in Prompts)
        {
            Console.WriteLine($"{i}. {prompt}");
            i += 1;
        }
    }
}
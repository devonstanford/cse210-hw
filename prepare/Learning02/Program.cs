using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.Company = "Microsoft";
        job1.StartYear = 1989;
        job1.EndYear = 2008;

        //job1.Display();
        Console.WriteLine(job1.JobTitle);
    }
}
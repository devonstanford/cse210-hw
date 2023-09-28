using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.Company = "Microsoft";
        job1.StartYear = 2019;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.JobTitle = "Manager";
        job2.Company = "Apple";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}
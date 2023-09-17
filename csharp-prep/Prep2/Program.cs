using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Change passingGrade to the grade threshold for passing
        int passingGrade = 70;
        char letterGrade = 'N';
        int numberGrade;
        
        Console.WriteLine("What is your percentage grade?");
        string grade = Console.ReadLine();
        
        if (int.TryParse(grade, out numberGrade))
        {
            if (numberGrade >= 90 && numberGrade <= 100)
            {
            letterGrade = 'A';
            }
            else if (numberGrade >= 80)
            {
                letterGrade = 'B';
            }
            else if (numberGrade >= 70)
            {
                letterGrade = 'C';
            }
            else if (numberGrade >= 60)
            {
                letterGrade = 'D';
            }
            else if (numberGrade < 60 && numberGrade >=0)
            {
                letterGrade = 'F';
            }
            else
            {
                Console.WriteLine("Not a valid grade. Please run again.");
                Environment.Exit(0);
            }

            Console.WriteLine($"Your final grade is {letterGrade}.");
            if (numberGrade >= passingGrade)
            {
                Console.WriteLine("You passed! Congrats!");
            }
            else
            {
               Console.WriteLine("You failed. Sorry.");
            }
        }
        else
        {
            Console.WriteLine("Not a valid grade. Please run again.");
        }
    }
}
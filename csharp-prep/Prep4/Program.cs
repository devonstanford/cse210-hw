using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 69;
        bool isDone = false;

        Console.WriteLine("Please enter a list of numbers one at a time. Type 0 when finished.");
        
        while (!isDone)
        {
            string tempNum;
            Console.WriteLine("Enter Number:");
            tempNum = Console.ReadLine();

            if (int.TryParse(tempNum, out num))
            {
                if (num != 0)
                {
                    numbers.Add(num);
                }
                else
                {
                    isDone = true;
                }
            }
            else
            {
                Console.WriteLine("Not a valid number.");
            }
            
        }
        
        int sum = 0;
        float average = 0;
        int largeNum = 0;

        foreach (int i in numbers)
        {
            sum += i;

            if (i > largeNum)
            {
                largeNum = i;
            }
        }

        if (numbers.Count != 0)
        {
            average = sum / numbers.Count;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largeNum}");
    }
}
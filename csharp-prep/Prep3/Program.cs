using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        bool finished = false;
        int bestAttempt = 0;

        while (!finished)
        {
            int numGuessed = 0;
            int attempts = 0;
            int magicNum = randomGenerator.Next(1,100);
            string cont;

            while (numGuessed != magicNum)
            {
                string tempGuess;
                Console.WriteLine("Please guess a number between 1 and 100.");
                tempGuess = Console.ReadLine();

                if (int.TryParse(tempGuess, out numGuessed))
                {
                    if (numGuessed >= 1 && numGuessed <= 100)
                    {
                        attempts++;
                        if (numGuessed < magicNum)
                        {
                            Console.WriteLine("The magic number is higher than your guess.");
                        }
                        else
                        {
                            Console.WriteLine("The magic number is lower than your guess.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid number. Please try again.");
                }
            }
            Console.WriteLine("Congratulations!");
            if (attempts < bestAttempt)
            {
                bestAttempt = attempts;
                Console.WriteLine($"You guessed it in {attempts} guesses. That's your best yet!");
            }
            else if (attempts == bestAttempt)
            {
                Console.WriteLine($"You guessed it in {attempts} guesses. Your best attempt was also {attempts} guesses.");
            }
            else
            {
                Console.WriteLine($"You guessed it in {attempts} guesses. Your best attempt was {bestAttempt} guesses.");
            }
            
            Console.WriteLine("Enter any key to continue. If you wish to stop, enter N.");
            cont = Console.ReadLine();

            if (cont == "N" || cont == "n")
            {
                Console.WriteLine("Thanks for playing!");
                finished = true;
            }
        }
    }
}
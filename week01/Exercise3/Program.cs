using System;

class Program
{
    static void Main(string[] args)
    {
        bool userChoosesNumber = true; // Set to false to make the number random

        int magicNumber;

        if (userChoosesNumber)
        {
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
        }
        else
        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);
        }

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
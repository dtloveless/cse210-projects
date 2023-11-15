using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string userChoice;
        
        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            // Console.WriteLine(magicNumber);
            string response;
            int guess;
            int numGuesses = 0;
            do
            {
                Console.Write("What is your guess? ");
                response = Console.ReadLine();
                guess = int.Parse(response);
                numGuesses += 1;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

            } while (guess != magicNumber);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You got it in {numGuesses} guesses!");
            Console.Write("Do you want to play again ('yes'/'no')? ");
            userChoice = Console.ReadLine();

        } while (userChoice == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
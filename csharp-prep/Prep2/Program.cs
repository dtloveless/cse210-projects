using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade point earned for the class: ");
        string userInput = Console.ReadLine();
        int gradePoint = int.Parse(userInput);

        string letter;
        bool isPosSign = true;
        bool isNegSign = true;
        if (gradePoint >= 90)
        {
            letter = "A";
            isPosSign = false;
        }
        else if (gradePoint >= 80)
        {
            letter = "B";
        }
        else if (gradePoint >= 70)
        {
            letter = "C";
        }
        else if (gradePoint >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            isPosSign = false;
            isNegSign = false;
        }

        int remainder = gradePoint % 10;
        if (isPosSign && remainder >= 7)
        {
            letter += "+";
        }
        else if (isNegSign && remainder < 3 && gradePoint != 100)
        {
            letter += "-";
        }

        Console.WriteLine($"Letter earned: {letter}");
        if (gradePoint >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
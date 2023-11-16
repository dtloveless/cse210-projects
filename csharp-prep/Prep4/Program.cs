using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int newNumber;
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0) {break;}
            numbers.Add(newNumber);
        }
        
        int sum = 0;
        int largestNumber = numbers[0];
        int smallestPosNum;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
            if (num > 0 )
        }

        float avg = sum / numbers.Count();
        numbers.

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
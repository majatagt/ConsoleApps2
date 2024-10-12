using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        CalculateSumBetweenNumbers();
    }

    public static void CalculateSumBetweenNumbers()
    {
        int firstNumber = 0, secondNumber = 0;

        while (true)
        {
            firstNumber = GetNumber("Please provide the first number: ");
            secondNumber = GetNumber("Please provide the second number: ");

            if (firstNumber.HasValue && secondNumber.HasValue)
                break;
            else
                Console.WriteLine("Invalid input. Please enter two valid numbers.");
        }

        // Generate a range of numbers between first and second number
        var numbersInRange = GenerateRange(firstNumber.Value, secondNumber.Value);

        // Filter and print even numbers
        var evenNumbers = numbersInRange.Where(IsEven);
        Console.WriteLine($"Even numbers between {firstNumber} and {secondNumber}: {string.Join(", ", evenNumbers)}");

        // Filter and print odd numbers
        var oddNumbers = numbersInRange.Where(IsOdd);
        Console.WriteLine($"Odd numbers between {firstNumber} and {secondNumber}: {string.Join(", ", oddNumbers)}");
    }

    // Function to get a number from the user
    public static int? GetNumber(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        if (int.TryParse(input, out int parsedNumber))
        {
            return parsedNumber;
        }
        else
        {
            Console.WriteLine("Invalid input - please enter an integer.");
            return null;
        }
    }

    // Function to generate the range of numbers between two inputs (inclusive)
    public static IEnumerable<int> GenerateRange(int start, int end)
    {
        return Enumerable.Range(Math.Min(start, end), Math.Abs(start - end) + 1);
    }

    // Pure function to check if a number is even
    public static bool IsEven(int number) => number % 2 == 0;

    // Pure function to check if a number is odd
    public static bool IsOdd(int number) => number % 2 != 0;
}

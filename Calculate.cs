using System;
using System.Linq;
using System.Collections.Generic;

public class MathWorks
{
    public static (int,int) Calculate()
    {
        bool number1 = false;
        int firstNumberInt = 0;
        bool number2 = false;
        int secondNumberInt = 0;
        while (!number1)
        {
            Console.WriteLine("Let's calculate the sum of two numbers!");
            Console.WriteLine("Please give first number: ");
            string firstNumber = Console.ReadLine();
            if (int.TryParse(firstNumber, out int outputnumber1))
            {
                firstNumberInt = outputnumber1; // set number 
                number1 = true;
            }
            else
            {
                Console.WriteLine("Invalid input - please enter numeric values. ");
            }

            while (!number2)
            {
                Console.WriteLine("Please give the second number: ");
                string secondNumber = Console.ReadLine();
                if (int.TryParse(secondNumber, out int outputnumber2))
                {
                    secondNumberInt = outputnumber2; // set number 2
                    number2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input - please enter numeric values. ");
                }
                
            }
            return (firstNumberInt, secondNumberInt);


        }

    }

    public void SumNumbers(int firstNumber, int secondNumber)
    {
        {
        double total = firstNumber + secondNumber;
        Console.WriteLine($"The sum of numbers {firstNumber} and {secondNumber} is: {total}");

        }
    }

    public void PrintEvenNumbers(int startNumber, int endNumber)
    {
      if (startNumber % 2 != 0) //check that the first number is even, if not even then start from the next even number
      {
            startNumber++;
      }
      for (int numbers = startNumber; numbers <= endNumber; numbers +=2) 
        {
            Console.WriteLine(numbers);
        }
       
    }



    public void PrintOddNumbers(int startNumber, int endNumber)
    {
        if (startNumber % 2 == 0)
        {
            startNumber++;
        }
        for (int numbers = startNumber; numbers <= endNumber; numbers += 2)
        {
            Console.WriteLine(numbers);
        }

    }

    //using a nested loop, calculates the square root of numbers within the range.
    //In each iteration, it should calculate from the counter's current value to the end number.
    public void CalculateSquareRoot(int firstNumber, int secondNumber) 
    {
        for (int sqrt = firstNumber; sqrt <= secondNumber; sqrt++)
        {
            for (int numbers = sqrt; numbers <= secondNumber; numbers++)

            {
                double sqrt1 = Math.Sqrt(numbers);
                Console.WriteLine($"the square root of {sqrt} is {sqrt1}");
            }
        }

    }
}




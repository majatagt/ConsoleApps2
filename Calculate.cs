


using System.Numerics;
using System.Security.Cryptography.X509Certificates;

internal class Calculate
    {
    public int number1 = 0;
    public int number2 = 0;
    public double total;



    public void SumNumbers()
        
    {
        
        bool number1 = false;
        int firstNumberInt = 0;
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

        bool number2 = false;
        int secondNumberInt = 0;
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
        double total = firstNumberInt + secondNumberInt;
        Console.WriteLine($"The sum of numbers {firstNumberInt} and {secondNumberInt} is: {total}");
        }   
    }
        

    }
    public void PrintEvenNumbers()
    {
        Console.WriteLine($"The even numbers between {0} and {0} ");
    }

}


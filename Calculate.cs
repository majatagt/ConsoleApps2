public class MathWorks
{
    //static as there should not be instance varialbes
    public static int number1 = 0;
    public static int number2 = 0;
    public static double total;
    public static double total2;



    public void Calculate()
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
            }
        }
    }

    public void SumNumbers(int firstNumberInt, int secondNumberInt)
    {
        {
        double total = firstNumberInt + secondNumberInt;
        Console.WriteLine($"The sum of numbers {firstNumberInt} and {secondNumberInt} is: {total}");

        }
    }
    public void PrintEvenNumbers(int firstNumberInt, int secondNumberInt)
    {
      if (firstNumberInt % 2 != 0) //check that the first number is even, if not even then start from the next even number
      {
        firstNumberInt++;
      }
      for (int number = firstNumberInt; number <= secondNumberInt; number += 2)
      Console.WriteLine($"The even numbers between {firstNumberInt} and {secondNumberInt} is: {number}");
      }
}



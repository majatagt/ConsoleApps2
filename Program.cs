
using System.Runtime.CompilerServices;

namespace ConsoleApps2
{
    class Program
    {
        static void Main()
        { Console.Clear();
          Console.Title = "Assignment 2. >By: Maja Tägt>";
            Calculate calculate = new Calculate();
            calculate.Sum();


            ContinueToNextPart("Temperature Conversion++++++++");

        }

        public static void ContinueToNextPart(string title)
        { 
        Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
        Console.ReadLine();
        Console.Clear();
        Console.Title = title;



        TemperatureConverter temperatureConverter = new TemperatureConverter();
  

            StringFunctions stringFunctions = new StringFunctions();
            string answerCont; 
            do
            {
                Console.WriteLine($"+++++++++++++++++++{stringFunctions}+++++++++++++++++++");
                temperatureConverter.Start();
                stringFunctions.stringLength();
                Console.WriteLine();
                stringFunctions.PredictMyDay();
                Console.WriteLine();

                Console.WriteLine("Continue with another round? y/n: ");
                answerCont = Console.ReadLine();
            } while (answerCont.ToUpper() == "Y");
        }
        

    }
    
}
 






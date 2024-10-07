using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TemperatureConverter
{
    char menuOption;

    public void Start()
    {
        do
        {
            Console.WriteLine("Hi! Now you have the option to see converted temperatures in front of your eyes!");
            Console.WriteLine("1-- Select for temperatures converted from Fahrenheit to Celcius ");
            Console.WriteLine("2-- Select for temperatures converted from Celcius to Fahrenheit ");
            Console.WriteLine("0-- Select to exit ");


            string menuInput = Console.ReadLine();  // Store the input as a string
            if (!string.IsNullOrEmpty(menuInput))   // Check for empty input to avoid index errors
            {
                menuOption = menuInput[0];  // Access the first character safely
            }
            else
            {
                menuOption = ' ';  // Set default invalid character for empty input
            }

            if (menuOption == '1')
            {
                DisplayF(); // if selection is one from user, call this method and execute its code 
                Console.WriteLine();

            }
            else if (menuOption == '2')
            {
                DisplayC();
                Console.WriteLine();
            }

            else if (menuOption == '0')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please only choose from the menu options");
                Console.WriteLine();
            }
        } while (menuOption != '0');


    }
    public void DisplayF()
    {
        for (int fahrenheit = 0; fahrenheit < 212; fahrenheit++)
        {
            double celcius1 = (fahrenheit - 32) * 5.0 / 9.0;
            Console.WriteLine($"{fahrenheit}C = {celcius1:F0}F"); //Output the conversion, and do not include decimal places
        }
    }
    public void DisplayC() 
    {
        for (int celcius = 0; celcius < 100; celcius++)
        {
            double fahrenheit = (celcius + 32) * 9.0 / 5.0;
        Console.WriteLine($"{celcius}C = {fahrenheit:F0}F");
        }
    }
}









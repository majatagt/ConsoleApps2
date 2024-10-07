using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class StringFunctions
    {
    

        public void stringLength()
        { 
        Console.WriteLine("Please enter a word: ");
        string lenghtInput = Console.ReadLine();


        Console.WriteLine($"The length of {lenghtInput.ToUpper()} is {lenghtInput.Length} ");

        }

    public void PredictMyDay()
    {
        Console.WriteLine("Please enter a number between 1 and 7! ");
        string dayOption = Console.ReadLine();

        switch (dayOption)
        {
            case "1":
                Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                break;
            case "2":
                Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                break;
            case "3":
                Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                break;
            case "4":
                Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                break;
            case "5":
                Console.WriteLine("Friday, you are in love!");
                break;
            case "6":
                Console.WriteLine("Saturday, do nothing and do plenty of it!");
                break;
            case "7":
                Console.WriteLine("And Sunday always comes too soon!");
                break;
            default:
                Console.WriteLine("Invalid input! Please only choose between 1 - 7");
                break;
        }

    }
    public void RunAgain()
    {
        string answerCont = "";

        if (answerCont == "y" || answerCont == "Y")
        {
            Console.WriteLine("Yes");
        }
        else 
        {
            Console.WriteLine("nO");
        }
    }
}





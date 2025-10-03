using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
//    Skapa en liten miniräknare som klarar fyra räknesätt.
//Instruktioner:
//Be användaren skriva in två tal (ett i taget).
//Konvertera inmatningen till double.
//Räkna ut och skriv ut resultat för:
//Addition(+)
//Subtraktion(–)
//Multiplikation(*)
//Division(/)
//Visa alla resultat i konsolen.
    public class Calculator
    {
        // Method for calculator
        public void calculator() 
        {
            // Menu for calculator
            Console.WriteLine("Calculator");
            Console.WriteLine("Type a Number:");
            // Read user input and convert to double
            double num1 = Convert.ToDouble(Console.ReadLine());
            // Ask the user for an operator
            Console.WriteLine("Type a Operator (+, -, *, /):");
            // Read user input
            string op = Console.ReadLine();
            Console.WriteLine("Type a Number:");
            // Read user input and convert to double
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Initialize result variable
            double result = 0;
            // Perform the operation based on the operator input
            // Addition
            if (op == "+")
            {
                result = num1 + num2;
            }
            // Subtraction
            else if (op == "-") 
            {
                result = num1 - num2;
            }
            // Multiplication
            else if (op== "*")
            {
                result = num1 * num2;
            }
            // Division
            else if (op == "/")
            {
                result = num1 / num2;
            }

            // Display the result
            Console.WriteLine($"{num1} {op} {num2} = {result}");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string calculatorMenu = Console.ReadLine();
            if (calculatorMenu == "1")
            {
                Calculator calculator = new Calculator();
                calculator.calculator();
            }
            else if (calculatorMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }


        }
    }
}

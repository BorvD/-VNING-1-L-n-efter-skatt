using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
    // Skapa en mer ineraktiv meny som låter användaren välja vilket program de vill köra.
    // Knyt ihop alla tidigare uppgifter i denna meny.
    // Håll Program.cs så ren som möjligt.
    public class MainMenu
    {

        // Main menu method
        public void mainMenu() 
        {
            // Menu for main menu
            Console.WriteLine("Choose what program you wanna run bu typing its number");
            Console.WriteLine("1: Calculate your salary after taxes");
            Console.WriteLine("2: Calculate how much fuel the vehicle use");
            Console.WriteLine("3: Calculate the area of a shape");
            Console.WriteLine("4: Bank account deposit");
            Console.WriteLine("5: AI chatbot");
            Console.WriteLine("6: Calculator");
            // Read user input
            string mainMenu = Console.ReadLine();
            // Conditional statements for user input which program to run
            // If user input is 1, create a new SalaryCalculator object and call its CalculateNetSalary method
            if (mainMenu == "1")
            {
                SalaryCalculator salaryCalculator = new SalaryCalculator();
                salaryCalculator.CalculateNetSalary();
            }
            // If user input is 2, create a new Vehicle object and call its vehicle method
            else if (mainMenu == "2")
            {
                Vehicle vehicle = new Vehicle();
                vehicle.vehicle();
            }
            // If user input is 3, create a new ShapeMenu object and call its shape method
            else if (mainMenu == "3")
            {
                ShapeMenu shape = new ShapeMenu();
                shape.shape();
            }
            // If user input is 4, create a new BankAccount object and call its bankAccount method
            else if (mainMenu == "4")
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.bankAccount();
            }
            // If user input is 5, create a new AiChatbot object and call its aiChatbot method
            else if (mainMenu == "5")
            {
                AiChatbot aiChatbot = new AiChatbot();
                aiChatbot.aiChatbot();
            }
            else if (mainMenu == "6")
            {
                Calculator calculator = new Calculator();
                calculator.calculator();
            }
        }

    }
}

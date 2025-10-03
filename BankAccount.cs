using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ÖVNING_1___Lön_efter_skatt
{
    public class BankAccount
    {
        // Private field to store the balance
        private double balance;
        // Public property to get and set the balance with validation
        public double Balance
        {
            // Getter returns the current balance
            get { return balance; }
            // Setter checks if the value is negative before setting the balance
            set
            {
                // Check if the value is negative
                if (value < 0)
                {
                    // Print an error message if the value is negative
                    Console.WriteLine("Fel: Du kan inte sätta in ett negativt belopp.");
                }
                // If the value is not negative, set the balance
                else
                {
                    balance = value;
                }
            }
        }

        // Method to handle bank account operations
        public void bankAccount()
        {
            // Create a new instance of BankAccount
            BankAccount account = new BankAccount();

            // Askes the user for the deposit amount
            Console.WriteLine("Write the amount you wanna deposit:");

            // Reads the user input and converts it to a double
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            // Sets the balance using the property  
            account.Balance = depositAmount;

            // Displays the current balance
            Console.WriteLine($"Your balance is now: {account.Balance}:-");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string bankAccountMenu = Console.ReadLine();
            if (bankAccountMenu == "1")
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.bankAccount();
            }
            else if (bankAccountMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }
}

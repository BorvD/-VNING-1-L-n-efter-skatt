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
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fel: Du kan inte sätta in ett negativt belopp.");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public void bankAccount()
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Write the amount you wanna deposit:");

            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Balance = depositAmount;

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

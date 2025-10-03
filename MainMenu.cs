using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
    public class MainMenu
    {
        public void mainMenu() 
        {
            Console.WriteLine("Choose what program you wanna run bu typing its number");
            Console.WriteLine("1: Calculate your salary after taxes");
            Console.WriteLine("2: Calculate how much fuel the vehicle use");
            Console.WriteLine("3: Calculate the area of a shape");
            Console.WriteLine("4: Bank account deposit");
            string mainMenu = Console.ReadLine();
            if (mainMenu == "1")
            {
                SalaryCalculator salaryCalculator = new SalaryCalculator();
                salaryCalculator.CalculateNetSalary();
            }
            else if (mainMenu == "2")
            {
                Vehicle vehicle = new Vehicle();
                vehicle.vehicle();
            }
            else if (mainMenu == "3")
            { 
                ShapeMenu shape = new ShapeMenu();
                shape.shape();
            }
            else if (mainMenu == "4")
                {
                BankAccount bankAccount = new BankAccount();
                bankAccount.bankAccount();
            }
        }

    }
}

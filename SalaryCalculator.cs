using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
    //Skapa en Console Application.
    //Skapa en klass SalaryCalculator med publika variabler eller properties för:

    //Bruttolön
    //Skattesats(t.ex. 30 %)

    //Skapa en metod CalculateNetSalary() som returnerar nettolönen(lön efter skatt).
    //I Program.cs:

    //Be användaren mata in bruttolön och skattesats via Console.ReadLine()
    //Skapa ett objekt av klassen och skriv ut nettolönen med Console.WriteLine()
    public class SalaryCalculator
    {
        // Method to calculate net salary
        public void CalculateNetSalary()
        {
            // Ask the user for their gross salary
            Console.WriteLine("Ange din bruttolön");
            // Convert the user's input to an integer
            int brutto = Convert.ToInt32(Console.ReadLine());

            // Ask the user for their tax rate in percent
            Console.WriteLine("Ange din skattesats i procent (bara siffror)");
            // Convert the user's input to a double
            double percent = Convert.ToInt32(Console.ReadLine());
            // Calculate the net salary
            double netto = (percent / 100) * brutto;
            // Subtract the tax from the gross salary to get the net salary
            Console.WriteLine($"Din bruttolön: {brutto}  Din skattesats: {percent}  Din Nettolön: {netto}");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string salaryMenu = Console.ReadLine();
            if (salaryMenu == "1")
            {
                SalaryCalculator salaryCalculator = new SalaryCalculator();
                salaryCalculator.CalculateNetSalary();
            }
            else if (salaryMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }
}

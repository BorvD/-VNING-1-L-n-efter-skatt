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
        public void CalculateNetSalary()
        {
            Console.WriteLine("Ange din bruttolön");
            int brutto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange din skattesats i procent (bara siffror)");
            double percent = Convert.ToInt32(Console.ReadLine());
            double netto = (percent / 100) * brutto;

            Console.WriteLine($"Din bruttolön: {brutto}  Din skattesats: {percent}  Din Nettolön: {netto}");
        }
    }
}

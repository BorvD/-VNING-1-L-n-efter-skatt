using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
    //Skapa en Console Application.
    //Skapa en basklass Vehicle med:
    //Egenskaper: Name, FuelConsumption (liter per mil)
    //En virtuell metod CalculateEfficiency() – som skriver ut hur långt fordonet kommer på 10 liter bränsle
    //Skapa två subklasser, t.ex.Car och Motorcycle, som ärver från Vehicle.
    //I varje subklass, skriv över metoden CalculateEfficiency() (använd override) för att ge ett unikt meddelande beroende på fordonstyp.
    //I Program.cs:
    //Skapa ett objekt av Car
    //Skapa ett objekt av Motorcycle
    //Anropa CalculateEfficiency() på båda objekten, men via Vehicle-typ om möjligt
    //internal class Vehicle
    public class Vehicle
    {
        public void vehicle() 
        {
            Console.WriteLine("Calculate how fuelefficent your vehicle is. Type the number of the vehicle you wanna calculate");
            Console.WriteLine("1: Vehicle");
            Console.WriteLine("2: Car");
            Console.WriteLine("3: Motorcycle");
            Console.WriteLine("0: Return to main menu");
            string vehicleMenu = Console.ReadLine();
            if (vehicleMenu == "1")
            {
                Vehicle vehicle = new Vehicle();
                vehicle.fuelConsumption();
            }
            else if (vehicleMenu == "2")
            {
                Car car = new Car();
                car.fuelConsumption();
            }
            else if (vehicleMenu == "3")
            {
                Motorcycle motorcycle = new Motorcycle();
                motorcycle.fuelConsumption();
            }
            else if (vehicleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
        public virtual void fuelConsumption()
        {
            Console.WriteLine("Calculate how fuelefficent your vehicle is");
            Console.WriteLine("Type how far you drive in km");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type how many liters that was used");
            double liters = Convert.ToDouble(Console.ReadLine());

            double fuelefficeny = liters / km;

            Console.WriteLine($"How far you drove: {km}. How many liters: {liters} = {fuelefficeny} liters per Km");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string vehicleMenu = Console.ReadLine();
            if (vehicleMenu == "1")
            {
                Vehicle vehicle1 = new Vehicle();
                vehicle1.vehicle();
            }
            else if (vehicleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }


    }

    public class Car : Vehicle
    {
        public override void fuelConsumption()
        {
            Console.WriteLine("Calculate how fuelefficent your car is");
            Console.WriteLine("Type how far you drive in km");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type how many liters that was used");
            double liters = Convert.ToDouble(Console.ReadLine());

            double fuelefficeny = liters / km;

            Console.WriteLine($"How far you drove: {km}. How many liters: {liters} = {fuelefficeny} liters per Km");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string vehicleMenu = Console.ReadLine();
            if (vehicleMenu == "1")
            {
                Vehicle vehicle1 = new Vehicle();
                vehicle1.vehicle();
            }
            else if (vehicleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void fuelConsumption()
        {
            Console.WriteLine("Calculate how fuelefficent your car is");
            Console.WriteLine("Type how far you drive in km");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type how many liters that was used");
            double liters = Convert.ToDouble(Console.ReadLine());

            double fuelefficeny = liters / km;

            Console.WriteLine($"How far you drove: {km}. How many liters: {liters} = {fuelefficeny} liters per Km");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string vehicleMenu = Console.ReadLine();
            if (vehicleMenu == "1")
            {
                Vehicle vehicle1 = new Vehicle();
                vehicle1.vehicle();
            }
            else if (vehicleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }
}

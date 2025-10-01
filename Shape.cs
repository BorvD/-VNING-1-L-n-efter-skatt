using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{

    //Skapa en abstrakt klass Shape med en metod CalculateArea().
    //Skapa klasser Circle, Rectangle och Square som ärver från Shape och implementera CalculateArea() för varje form.
    //Be användaren att mata in de nödvändiga måtten och sedan beräkna och visa arean.
    abstract class Shape
    {
        public abstract void shape();
    }

    class ShapeMenu : Shape 
    {
        public override void shape()
        {
            Console.WriteLine("Calculate the area of:");
            Console.WriteLine("1: Rektangel");
            Console.WriteLine("2: Circle");
            Console.WriteLine("3: Triangel");
            Console.WriteLine("0: Return to Main menu");
            Console.WriteLine($"Type:");
            string shapeMenu = Console.ReadLine();
            if (shapeMenu == "1")
            {
                Rektangel rektangel = new Rektangel();
                rektangel.shape();
            }
            else if (shapeMenu == "2")
            { 
                Circle circle = new Circle();
                circle.shape();
            }
            else if(shapeMenu == "3")
            {
                Triangle triangle = new Triangle();
                triangle.shape();
            }
        }

    }

    class Rektangel : Shape
    {
        public override void shape()
        {
            Console.WriteLine("Write the length");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the width");
            double hight = Convert.ToDouble(Console.ReadLine());

            double area = length * hight;
            Console.WriteLine($"Length:{length} * Hight:{hight} = Area:{area}");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string rektangleMenu = Console.ReadLine();
            if (rektangleMenu == "1")
            {
                ShapeMenu shapeMenu1 = new ShapeMenu();
                shapeMenu1.shape();
            }
            else if (rektangleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }

    class Circle : Shape 
    {
        public override void shape() 
        {
            Console.WriteLine("Write the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is: {area}");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string circleMenu = Console.ReadLine();
            if (circleMenu == "1")
            {
                ShapeMenu shapeMenu1 = new ShapeMenu();
                shapeMenu1.shape();
            }
            else if (circleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }

    class Triangle : Shape
    {
        public override void shape()
        {
            Console.WriteLine("Write the length");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the width");
            double hight = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * length * hight;
            Console.WriteLine($"The area of your triangle: {area}");

            Console.WriteLine($"Type:");
            Console.WriteLine($"1: Make new calculation");
            Console.WriteLine($"0: Return to main menu");
            string rektangleMenu = Console.ReadLine();
            if (rektangleMenu == "1")
            {
                ShapeMenu shapeMenu1 = new ShapeMenu();
                shapeMenu1.shape();
            }
            else if (rektangleMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }
}

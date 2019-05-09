using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Menu
    {
        public static int DisplayMainMenu()
        {
            Console.WriteLine("What shape would you like to add?");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Triangle");
            Console.WriteLine("3 - Circle ");
            Console.WriteLine("4 - Calculate");
            Console.WriteLine("5 - List all shapes");
            Console.Write("Enter 1-5: ");

            if (int.TryParse(Console.ReadLine(), out int userSelection) && userSelection >= 1 && userSelection <= 5)
            {
                return userSelection;
            }
            else
            {
                return 0;
            }
        }

        public static void AddSquareMenu(List<ShapeBase> shapeList)
        {
            Console.Write("Enter length of side: ");

            if (double.TryParse(Console.ReadLine(), out double side))
            {
                shapeList.Add(new Square(side));
                Console.WriteLine("Square added to list");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
        public static void AddTriangleMenu(List<ShapeBase> shapeList)
        {
            Console.WriteLine("Enter lengths of all three sides: ");

            if (double.TryParse(Console.ReadLine(), out double length1) && double.TryParse(Console.ReadLine(), out double length2) && double.TryParse(Console.ReadLine(), out double length3))
            {
                shapeList.Add(new Triangle(length1, length2, length3));
                Console.WriteLine("Triangle added to list");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
        public static void AddCircleMenu(List<ShapeBase> shapeList)
        {
            Console.Write("Enter radius of circle: ");

            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                shapeList.Add(new Circle(radius));
                Console.WriteLine("Circle added to list");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }

    }
}

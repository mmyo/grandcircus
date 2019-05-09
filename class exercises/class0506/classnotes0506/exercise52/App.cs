using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class App
    {
        public static void Run()
        {
            var shapeList = new List<ShapeBase>();
            var quitApp = "N";

            do
            {
                Console.Clear();
                var userSelection = Menu.DisplayMainMenu();

                switch (userSelection)
                {
                    case 1:
                        Menu.AddSquareMenu(shapeList);
                        break;
                    case 2:
                        Menu.AddTriangleMenu(shapeList);
                        break;
                    case 3:
                        Menu.AddCircleMenu(shapeList);
                        break;
                    case 4:
                        CalculateAreaAndPerimeter(shapeList);
                        break;
                    case 5:
                        DisplayAllShapes(shapeList);
                        break;
                    default:
                        quitApp = "y";
                        Console.WriteLine("\nBye");
                        break;
                }
                Console.ReadLine();

            } while (quitApp.Equals("n", StringComparison.OrdinalIgnoreCase));     
        }

        public static double GetShapesTotalArea(List<ShapeBase> shapeList)
        {
            double totalArea = 0;

            foreach (var shape in shapeList)
            {
                totalArea = totalArea + shape.GetArea();          
            }

            return totalArea;
        }

        public static double GetShapesTotalPerimeter(List<ShapeBase> shapeList)
        {
            double totalPerimeter = 0;

            foreach (var shape in shapeList)
            {
                totalPerimeter = totalPerimeter + shape.GetPerimeter();
            }

            return totalPerimeter;
        }

        public static void CalculateAreaAndPerimeter(List<ShapeBase> shapeList)
        {
            Console.WriteLine($"There are {shapeList.Count} shape(s) in list");
            Console.WriteLine($"\nTotal area of {shapeList.Count} shapes: {GetShapesTotalArea(shapeList)}");
            Console.WriteLine($"Total perimeter of {shapeList.Count} shapes: {GetShapesTotalPerimeter(shapeList)}");
            Console.WriteLine($"\nAverage area of {shapeList.Count} shapes: {GetShapesTotalArea(shapeList) / shapeList.Count}");
            Console.WriteLine($"Average perimeter of {shapeList.Count} shapes: {GetShapesTotalPerimeter(shapeList) / shapeList.Count}");
        }

        public static void DisplayAllShapes(List<ShapeBase> shapeList)
        {
            Console.WriteLine($"There are {shapeList.Count} shape(s) in list:");

            foreach (var shape in shapeList)
            {
                Console.WriteLine($"{shape.GetType()} | Perimeter: {shape.GetPerimeter()} | Area: {shape.GetArea()}");
            }
        }
    }
}

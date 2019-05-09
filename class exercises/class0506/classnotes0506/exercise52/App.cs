using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    class App
    {
        public static void Run()
        {
            var square = new Square();
            square.Side = 4;
            Console.WriteLine($"Square area: {square.GetArea()}");
            Console.WriteLine($"Square perimeter: {square.GetPerimeter()}");
            Console.WriteLine();

            var triangle = new Triangle();
            triangle.Length1 = 5;
            triangle.Length2 = 5;
            triangle.Length3 = 5;
            Console.WriteLine($"Triangle area: {triangle.GetArea()}");
            Console.WriteLine($"Triangle perimeter: {triangle.GetPerimeter()}");
            Console.WriteLine();

            var circle = new Circle();
            circle.Radius = 24;
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Circle perimeter: {circle.GetPerimeter()}");
            Console.WriteLine();

            var shapeList = new List<ShapeBase>();
            shapeList.Add(square);
            shapeList.Add(triangle);
            shapeList.Add(circle);
            
            Console.WriteLine($"Total area: {GetShapesTotalArea(shapeList)}");
            Console.WriteLine($"Total perimeter: {GetShapesTotalPerimeter(shapeList)}");
            Console.WriteLine();

            Console.WriteLine($"Average area of {shapeList.Count} shapes: {GetShapesTotalArea(shapeList) / shapeList.Count}");
            Console.WriteLine($"Average perimeter of {shapeList.Count} shapes: {GetShapesTotalPerimeter(shapeList) / shapeList.Count}");

            Console.ReadLine();
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
    }
}

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
            Console.WriteLine($"Triangle: {triangle.GetArea()}");
            Console.WriteLine($"Triangle: {triangle.GetPerimeter()}");
            Console.WriteLine();


            var circle = new Circle();
            circle.Radius = 24;
            Console.WriteLine($"Circle: {circle.GetArea()}");
            Console.WriteLine($"Circle: {circle.GetPerimeter()}");
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}

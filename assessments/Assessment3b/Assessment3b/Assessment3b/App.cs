using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public class App
    {
        public static void Run()
        {

            Console.WriteLine("Let's create a house");
            House house = new House();

            Console.Write("Enter length: ");
            house.Length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            house.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            house.Height = double.Parse(Console.ReadLine());

            Console.WriteLine(BuildingProgram.DescribeBuilding(house));
            Console.WriteLine();

            Console.WriteLine("Let's create a pyramid");
            Pyramid pyramid = new Pyramid();

            Console.Write("Enter length: ");
            pyramid.Length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            pyramid.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            pyramid.Height = double.Parse(Console.ReadLine());

            Console.WriteLine(BuildingProgram.DescribeBuilding(pyramid));
            Console.WriteLine();

            Console.WriteLine("Let's create the Great Pyramid");
            var greatPyramid = BuildingProgram.BuildGreatPyramid();
            Console.WriteLine($"The great pyramid is {greatPyramid.Length} length, {greatPyramid.Width} width, {greatPyramid.Height} height.");
            Console.WriteLine(BuildingProgram.DescribeBuilding(greatPyramid));

        }
    }
}

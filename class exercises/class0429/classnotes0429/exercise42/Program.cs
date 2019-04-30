using System;

namespace exercise42
{
    class Program
    {
        static void Main(string[] args)
        {

            var userPoint = new Point();

            Console.Write("Enter an X coordinate: ");
            userPoint.X = double.Parse(Console.ReadLine());

            Console.Write("Enter a Y coordinate: ");
            userPoint.Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"You have created a point object ({userPoint.X}, {userPoint.Y})");

            Console.WriteLine($"Distance from 0,0 is: {userPoint.CalculateDistance()}");

            Console.ReadLine();
        }
    }
}

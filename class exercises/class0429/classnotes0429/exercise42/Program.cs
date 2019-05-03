using System;

namespace exercise42
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userPoint = new _3dPoint();

            Console.Write("Enter an X coordinate: ");
            userPoint.PointX = double.Parse(Console.ReadLine());

            Console.Write("Enter a Y coordinate: ");
            userPoint.PointY = double.Parse(Console.ReadLine());

            Console.WriteLine($"You have created a point object ({userPoint.PointX}, {userPoint.PointY})");

            Console.WriteLine($"Distance from 0,0 is: {userPoint.CalculateDistance()}");

            Console.Write("Enter second X: ");
            userPoint.SecondX = double.Parse(Console.ReadLine());
            Console.Write("Enter second Y: ");
            userPoint.SecondY = double.Parse(Console.ReadLine());

            Console.WriteLine($"The midpoint is {userPoint.CalculateMidpoint()}");

            Console.ReadLine();
        }
    }
}

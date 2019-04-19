using System;

namespace Assessment1a
{
    class Challenge
    {
        static void Main(string[] args)
        {
            //Tests
            Console.WriteLine("Test Method 1 \nEnter grade");
            double gradeIsPassingTest = double.Parse(Console.ReadLine());
            Console.WriteLine(IsPassing(gradeIsPassingTest));

            Console.WriteLine("\nTest Method 2 \nEnter grade");
            double gradeIsPassingAndEvenOddTest = double.Parse(Console.ReadLine());
            Console.WriteLine(IsPassingAndEvenOrOdd(gradeIsPassingAndEvenOddTest));

            Console.WriteLine("\nTest Method 3\ngrade1: ");
            double grade1 = double.Parse(Console.ReadLine());
            Console.WriteLine("grade2: ");
            double grade2 = double.Parse(Console.ReadLine());
            Console.WriteLine("grade3: ");
            double grade3 = double.Parse(Console.ReadLine());

            var average = AverageGrades(grade1, grade2, grade3);
            Console.WriteLine($"Average: {average}");

            Console.ReadLine();
        }

        static bool IsPassing(double grade)
        {

            if (grade > 65)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        static double AverageGrades(double grade1, double grade2, double grade3)
        {
            return (grade1 + grade2 + grade3) / 3;
        }

        static string IsPassingAndEvenOrOdd(double grade)
        {
            double remainder = grade % 2;

            if (IsPassing(grade) && remainder > 0)
            {
                return "Passing and odd";
            }
            else if (IsPassing(grade) && remainder == 0)
            {
                return "Passing and even";
            }
            else if (!IsPassing(grade) && remainder > 0)
            {
                return "Failing and odd";
            }
            else if (!IsPassing(grade) && remainder == 0)
            {
                return "Failing and even";
            }
            else
            {
                return "Something bad happened";
            }

        }
    }
}

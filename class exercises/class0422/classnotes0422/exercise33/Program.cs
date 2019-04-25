using System;

namespace exercise33
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] coolArray = new int[5] { 2, 8, 0, 24, 51};

            PrintArrayToConsole(coolArray);

            Console.Write("\nEnter an index: ");

            if (int.TryParse(Console.ReadLine(), out int userIndex) && userIndex >= 0 && userIndex < coolArray.Length)
            {
                Console.WriteLine($"\nThe value at index {userIndex} is {coolArray[userIndex]}");
                Console.Write("\nWould like to change it? y/n: ");

                if (Console.ReadLine() == "y")
                {
                    Console.Write("\nEnter new value: ");

                    if (int.TryParse(Console.ReadLine(), out int newNumber))
                    {
                        coolArray[userIndex] = newNumber;

                        Console.WriteLine("\nArray updated:");
                        PrintArrayToConsole(coolArray);
                    }                                      
                }
            }
            Console.ReadLine();
        }

        static void PrintArrayToConsole(int[] arrayName)
        {
            foreach (var item in arrayName)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

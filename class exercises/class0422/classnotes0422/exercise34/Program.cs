using System;

namespace exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] awesomeArray = new int[] { 16, 32, 64, 128, 256 };

            DisplayArrayInConsole(awesomeArray);

            Console.Write("\nEnter a command (double/half): ");

            switch (Console.ReadLine().Trim().ToLower())
            {
                case "double":
                    DoubleItemsInArray(awesomeArray);
                    DisplayArrayInConsole(awesomeArray);
                    break;
                case "half":
                    HalfItemsInArray(awesomeArray);
                    DisplayArrayInConsole(awesomeArray);
                    break;                    
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }

        static void DoubleItemsInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 2;
            }
        }

        static void HalfItemsInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] / 2;
            }
        }

        static void DisplayArrayInConsole(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

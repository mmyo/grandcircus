using System;

namespace classnotes0422
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] intArray = new int[] { 2, 5, 5, 1, 2, 3 }; //"object literal" 

            string[] stringArray = new string[5];

            int[] intArrayTwo = { 2, 3, 5, 6, 7 }; //not often used

            int[] intArrayCopy = intArrayTwo; //pointing to same reference

            //access data in an array
            //int indexOne = intArrayTwo[0];

            //intArrayTwo[0] = 6;

            //Console.WriteLine($"array re-assigned: {intArrayTwo[0]}");
            //Console.WriteLine($"indexOne variable: {indexOne}");
            //Console.WriteLine($"intArrayTwo original at index one {intArrayTwo[0]}");

            //Console.WriteLine(indexOne);

            string[] names = new string[] { "james", "john", "alex", "andrew", "joey" };

            string[] states = {"TX", "IL", "MI" };

            Console.WriteLine(states);

            int numberOfJs = GetNamesWithThisFirstLetter(names, 'j');
            Console.Write(numberOfJs);

            //Another way to assign an array. assigning by index
            double[] numbers = new double[3];
            numbers[0] = 2.2;
            numbers[0] = 1.0;
            numbers[0] = 3.0;

            Console.WriteLine(numbers[0]);

            Console.ReadLine();

        }

        static int GetNamesWithThisFirstLetter(string [] names, char firstLetter)
        {
            int count = 0;
             
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith(firstLetter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

using System;
using System.Text;

namespace exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            var userString = Console.ReadLine();
            StringBuilder newString = new StringBuilder();
            string newWord2 = null;
            var userStringPosition = userString.Length - 10 ;

            if (userString.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    newWord2 = newWord2 + userString[userStringPosition];
                    newString.Append(userString[userStringPosition]);
                    userStringPosition++;
                }
            }
            else
            {
                Console.WriteLine("Enter a string longer than 10 characters");
            }

            Console.WriteLine($"Using string concatenation: {newWord2}");
            Console.WriteLine($"Using string builder: {newString}");

            Console.ReadLine();
        }
    }
}

using System;

namespace exercise23_ten_characters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter some text: ");
            string userText = Console.ReadLine();

            Console.WriteLine(userText.Substring(0, 10));

            Console.ReadKey();
        }
    }
}

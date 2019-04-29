using System;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userWord = Console.ReadLine();
            Console.Write("Enter a character to count: ");

            try
            {
                char.TryParse(Console.ReadLine(), out char userLetter);
                Console.WriteLine($"{userLetter} occurs {CountOccurencesOfChar(userWord.ToLower(), userLetter)} time(s)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uh....");
                Console.WriteLine(ex.Message);
                //throw;
            }
      
            Console.ReadLine();
        }

        public static int CountOccurencesOfChar(string userWord, char userLetter)
        {
            int charCount = 0;

            for (int i = 0; i < userWord.Length; i++)
            {
                if (userWord[i] == Char.ToLower(userLetter))
                {
                    charCount++;
                }
            }

            return charCount;
        }
    }
}

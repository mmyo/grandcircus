using System;
using System.Text;

namespace exercise21_stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            string userWantsToEnterAnotherWord = null;

            string userSentence = null;

            do
            {
                Console.Write("Enter a word: ");
                string word = Console.ReadLine();
                userSentence = string.Concat(userSentence, word, " ");

                Console.Write("Do you want to add more words? y/n: ");
                userWantsToEnterAnotherWord = Console.ReadLine();
            } while (userWantsToEnterAnotherWord == "y");

            Console.WriteLine(userSentence);

            Console.ReadKey();
        }
    }
}

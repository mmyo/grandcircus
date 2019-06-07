using System;
using System.Collections.Generic;
using System.IO;

namespace exercise70
{
    class Program
    {
        static void Main(string[] args)
        {
            var spanishTranslationsDictionary = new Dictionary<string, string>();

            var userWantsToContinue = false;
            do
            {
                Console.Write("Enter [word] [translation]. Or [q]uit: ");
                var userInput = Console.ReadLine();

                if (userInput.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                AddToDictionary(userInput, spanishTranslationsDictionary);

                Console.Write("Add more? y/n: ");
                if (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    userWantsToContinue = true;
                }
                else
                {
                    userWantsToContinue = false;
                    SaveDictionaryToFile(spanishTranslationsDictionary);
                }

            } while (userWantsToContinue == true);

            Console.WriteLine("Bye");
            Console.ReadLine();
        }

        public static void AddToDictionary(string userInput, Dictionary<string,string> dictionary)
        {
            String[] userinputArray = userInput.Split(' ');

            if (userinputArray.Length == 2 && userinputArray[0] != "" && userinputArray[1] != "")
            {
                dictionary.TryAdd(userinputArray[0], userinputArray[1]);
                Console.WriteLine("Successfully added.");
            }
            else
            {
                Console.WriteLine("Weird input. Did not add.");
            }

        }

        public static void SaveDictionaryToFile(Dictionary<string, string> dicionary)
        {
            Console.Write("Name of file to save: ");
            var saveFile = Console.ReadLine();



            using (StreamWriter file = new StreamWriter(saveFile))

            foreach (var entry in dicionary)
            {
                file.WriteLine($"{entry.Key},{entry.Value}");
            }
        }



    }
}

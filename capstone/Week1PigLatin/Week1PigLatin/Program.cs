using System;
using System.Text;

namespace Week1PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Pig Latin Translator! \nEnter a word to translate: ");
            string userWord = Console.ReadLine();
            Console.WriteLine($"\nHere's the word in pig latin: {TranslateWordToPigLatin(userWord)}");

            Console.ReadLine();
        }

        static string TranslateWordToPigLatin(string word)
        {
            word = word.ToLower();

            //word starts with vowel, just add "way" at the end
            if (word.StartsWith("a") || word.StartsWith("e") || word.StartsWith("i") || word.StartsWith("o") || word.StartsWith("u"))
            {
                return $"{word}way";
            }
            //word starts with consonant, move all consonants to the end until first vowel, then add "ay"
            else
            {
                int firstVowelIndex = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    {
                        firstVowelIndex = i;
                        break;
                    }                                
                }                   
                return word.Substring(firstVowelIndex) + word.Substring(0,firstVowelIndex) + "ay";
            }
        }
    }
}

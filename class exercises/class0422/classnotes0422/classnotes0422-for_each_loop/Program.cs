using System;

namespace classnotes0422_for_each_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = new string[] { "Hamburger", "Tacos", "Pizza", "birthday cake"};

            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            Console.ReadLine();
        }

        static string GetPigLatin(string word)
        {
            const string vowels = "aeiou";

            var isVowel = false;
            foreach (var vowel in vowels)
            {
                if (word.StartsWith(vowel))
                {
                    isVowel = true;
                    break;
                }
            }

            string pigLatinWord;

            if(isVowel)
            {
                return $"{word}way";
            }
            else
            {
                var conIndex = 0;
                foreach (var letter in word)
                {
                    foreach (var vowel in vowels)
                    {
                        if (letter != vowel)
                        {
                            conIndex++;
                        }
                    }
                }
            }

            return "";
        }
    }
}

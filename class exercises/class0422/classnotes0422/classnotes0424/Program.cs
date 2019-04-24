using System;

namespace classnotes0424
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Please excuse my dear aunt sally    ";
            string[] words = sentence.Trim().Split(' ');
 
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine(words[3]);

            string[] names = new string[words.Length + 1];

            for (int i = 0; i < words.Length; i++)
            {
                names[i] = words[i];
            }

            names[names.Length - 1] = "."; //add period last index of the array

            words.CopyTo(names, 0);

            Array.Copy(words, names, words.Length);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace classnote0424_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "You did it");
            dictionary[1] = "You didn't do it";

            

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //Console.WriteLine(dictionary[1]);

            var guidDictionary = new Dictionary<Guid, string>();
            guidDictionary[Guid.NewGuid()] = "hi";

            foreach (var kvp2 in guidDictionary)
            {
                Console.WriteLine($"{kvp2.Key} : {kvp2.Value}");
            }

            Console.ReadLine();
        }
    }
}

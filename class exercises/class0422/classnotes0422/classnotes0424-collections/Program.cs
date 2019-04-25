using System;
using System.Collections.Generic;
using System.Linq;

namespace classnotes0424_collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> movies = new List<string>();
            var movies = new List<string>();

            movies.Add("Goonies");
            movies.Add("Star Wars");
            movies.Insert(1, "The Shining");

            //Console.WriteLine(movies[1]);
            string[] moreMovies = new string[] { "Die Hard" };

            //moreMovies.CopyTo(movies, 0);

           

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }

            var sentence2 = "Game of Thrones";
            var words2 = sentence2.Split(" ");

            var wordsList2 = new List<string>();

            wordsList2.AddRange(words2);

            string[] wordsArray2 = wordsList2.ToArray();
            List<string> sentence3 = wordsArray2.ToList();
        

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_movies
{
    class Menu
    {
        public static int DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Movie List");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - See all movies");
            Console.WriteLine("2 - See all movies in a category");
            Console.WriteLine("3 - Add movie");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int userSelection) && userSelection >= 1 && userSelection <=4)
            {
                return userSelection;
            }
            return 0;
        }

        public static string ChooseMovieCategoryMenu()
        {
            Console.Write("Which movie category: ");

            return Console.ReadLine();

        }

        public static void AddMovieMenu(List<Movie> moviesList)
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Category: ");
            var category = Console.ReadLine();

            moviesList.Add(new Movie(title, category));
        }

        public static void SeeAllMovies(List<Movie> moviesList)
        {
            Console.WriteLine($"There are {moviesList.Count} total:");

            foreach (var movie in moviesList)
            {
                Console.WriteLine(movie.Title);
            }
        }

        public static void SeeAllMovies(List<Movie> moviesList, string category)
        {

            foreach (var movie in moviesList)
            {
                if (movie.Category == category)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }
}

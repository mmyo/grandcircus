using System;
using System.Collections.Generic;
using System.Linq;

namespace lab11_movies
{
    public class Menu
    {
        public static Enum DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Movie List");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - See all movies (alphabetized)");
            Console.WriteLine("2 - See all movies (oldest->newest)");
            Console.WriteLine("3 - Search movies by category");
            Console.WriteLine("4 - See all categories");
            Console.WriteLine("5 - Add movie");
            Console.WriteLine("6 - Exit");
            Console.Write("Enter a number 1-6: ");

            if (Enum.TryParse<MenuEnums>(Console.ReadLine(), out var userMenuSelection))
            {
                return userMenuSelection;
            }
            return null;
        }

        public static void AddMovieMenu(List<Movie> moviesList)
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Category: ");
            var category = Console.ReadLine();

            Console.Write("Year: ");
            int.TryParse(Console.ReadLine(), out int year);

            moviesList.Add(new Movie(title, category, year));
            moviesList.Sort((x, y) => string.Compare(x.Title, y.Title));

            Console.WriteLine($"Movie added");
        
        }

        public static void DisplayAllMovies(List<Movie> moviesList)
        {
            moviesList.Sort((x, y) => string.Compare(x.Title, y.Title));

            Console.WriteLine($"There are {moviesList.Count} movie(s) in the list (a-z):\n");

            foreach (var movie in moviesList)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year}, {movie.Category})");
            }
        }

        public static void DisplayAllMovies(List<Movie> moviesList, bool OrderByYearAscending)
        {

            Console.WriteLine($"There are {moviesList.Count} movie(s) in the list (oldest to newest):\n");

            foreach (var movie in moviesList.OrderBy(x => x.Year))
            {
                Console.WriteLine($"{movie.Title} ({movie.Year}, {movie.Category})");
            }
        }

        public static void SearchMoviesByCategory(List<Movie> moviesList)
        {
            bool moviesFound = false;    
            Console.Write("Which movie category: ");
            var userSelectedCategory = Console.ReadLine();

            foreach (var movie in moviesList)
            {
                if (movie.Category.Equals(userSelectedCategory, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{movie.Title} ({movie.Year}, {movie.Category})");
                    moviesFound = true;
                }
            }

            if (moviesFound == false)
            {
                Console.WriteLine($"No movies found with {userSelectedCategory} category.");
            }
        }

        public static void DisplayAllCategories(List<string> categoryList)
        {
            categoryList.Sort();

            Console.WriteLine("Here is the list of categories (a-z):\n");
            foreach (var category in categoryList)
            {
                Console.WriteLine(category);
            }
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_movies
{
    public abstract class Menu
    {
        public static Enum DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Movie List");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - See all movies");
            Console.WriteLine("2 - Search movies by category");
            Console.WriteLine("3 - See all categories");
            Console.WriteLine("4 - Add movie");
            Console.WriteLine("5 - Exit");
            Console.Write("Enter a number: ");

            if (Enum.TryParse<MenuEnums>(Console.ReadLine(), out var userSelection))
            {
                return userSelection;
            }
            return null;
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
            Console.WriteLine($"Movie added");
        
        }

        public static void DisplayAllMovies(List<Movie> moviesList)
        {
            Console.WriteLine($"There are {moviesList.Count} movie(s) in the list:");

            foreach (var movie in moviesList)
            {
                Console.WriteLine(movie.Title);
            }
        }

        public static void DisplayAllMovies(List<Movie> moviesList, string category)
        {
            foreach (var movie in moviesList)
            {
                if (movie.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie.Title);
                }
            }

        }

        public static void DisplayAllCategories(List<Movie> movieList, HashSet<string> categoryList)
        {

            UpdateMoviesCategoriesList(movieList, categoryList);
            Console.WriteLine("Here is the list of categories:");

            foreach (var category in categoryList)
            {
                Console.WriteLine(category);
            }

        }

        public static void UpdateMoviesCategoriesList(List<Movie> movieList, HashSet<string> categoriesList)
        {
            foreach (var movie in movieList)
            {
                categoriesList.Add(movie.Category);
            }       
        }
    }
}

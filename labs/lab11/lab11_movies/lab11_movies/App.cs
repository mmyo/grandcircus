using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_movies
{
    public class App
    {
        public static void Run()
        {
            var movieList = InitializeMovieList();
            var categoriesList = InitializeCategoriesList(movieList);
            var quitApp = false;

            do
            {
                Console.Clear();

                switch (Menu.DisplayMainMenu())
                {
                    case MenuEnums.DisplayAllMovies:
                        Console.WriteLine();
                        Menu.DisplayAllMovies(movieList);
                        break;
                    case MenuEnums.SearchMoviesByCategory:
                        Console.WriteLine();
                        Menu.DisplayAllCategories(movieList, categoriesList);
                        Menu.DisplayAllMovies(movieList, Menu.ChooseMovieCategoryMenu());
                        break;
                    case MenuEnums.DisplayAllCategories: 
                        Console.WriteLine();
                        Menu.DisplayAllCategories(movieList, categoriesList);
                        break;
                    case MenuEnums.AddMovie: 
                        Console.WriteLine();
                        Menu.AddMovieMenu(movieList);
                        break;
                    case MenuEnums.Exit: 
                        quitApp = true;
                        Console.WriteLine("\nBye");
                        break;
                    default:
                        Console.WriteLine("\nDid not understand. Try Again.");
                        break;
                }
                Console.ReadLine();
            } while (quitApp.Equals(false));       
        }

        public static List<Movie> InitializeMovieList()
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Jaws", "Drama"));
            movieList.Add(new Movie("It", "Horror"));
            movieList.Add(new Movie("Toy Story", "Animated"));
            movieList.Add(new Movie("Spider-Man: Into The Spiderverse", "Animated"));
            movieList.Add(new Movie("Iron Man", "Scifi"));
            movieList.Add(new Movie("Godfather", "Drama"));
            movieList.Add(new Movie("Carrie", "Horror"));
            movieList.Add(new Movie("Titanic", "Drama"));

            return movieList;
        }

        public static HashSet<string> InitializeCategoriesList(List<Movie> movieList)
        {
            HashSet<string> categoriesList = new HashSet<string>();

            Menu.UpdateMoviesCategoriesList(movieList, categoriesList);

            return categoriesList;

        }
    }
}

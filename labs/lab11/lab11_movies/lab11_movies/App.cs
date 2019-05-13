using System;
using System.Collections.Generic;
using System.Linq;

namespace lab11_movies
{
    public class App
    {
        public static void Run()
        {
            var movieList = InitializeMovieList();
            
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
                        Menu.DisplayAllCategories(CreateUniqueCategoryList(movieList));
                        Menu.SearchMoviesByCategory(movieList);
                        break;
                    case MenuEnums.DisplayAllCategories: 
                        Console.WriteLine();
                        Menu.DisplayAllCategories(CreateUniqueCategoryList(movieList));
                        break;
                    case MenuEnums.AddMovie: 
                        Console.WriteLine();
                        Menu.AddMovieMenu(movieList);
                        break;
                    case MenuEnums.Exit: 
                        quitApp = true;
                        Console.WriteLine("\nBye");
                        break;
                    case MenuEnums.DisplayAllMoviesAscendingByYear:
                        Console.WriteLine();
                        Menu.DisplayAllMovies(movieList, true);
                        break;
                    default:
                        Console.WriteLine("\nDid not understand. Try Again.");
                        break;
                }
                Console.WriteLine("\n... press any key to continue ...");
                Console.ReadKey();

            } while (quitApp.Equals(false));       
        }

        public static List<Movie> InitializeMovieList()
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Jaws", "Drama", 1975));
            movieList.Add(new Movie("It", "Horror", 1990));
            movieList.Add(new Movie("Toy Story", "Animated", 1995));
            movieList.Add(new Movie("Spider-Man: Into The Spiderverse", "Animated", 2018));
            movieList.Add(new Movie("Iron Man", "Scifi", 2008));
            movieList.Add(new Movie("Godfather", "Drama", 1972));
            movieList.Add(new Movie("Carrie", "Horror", 1976));
            movieList.Add(new Movie("Titanic", "Drama", 1997));
            movieList.Add(new Movie("Spirited Away", "Animated - Japanese", 2001));
            movieList.Add(new Movie("The Avengers", "Action", 2012));
            movieList.Add(new Movie("Jerry Macguire", "Drama", 1996));
            movieList.Add(new Movie("Zoolander", "Comedy", 2001));
            movieList.Add(new Movie("Avatar", "Action", 2009));

            movieList.Sort((x, y) => string.Compare(x.Title, y.Title));

            return movieList;
        }

        public static List<string> CreateUniqueCategoryList(List<Movie> movieList)
        {
            HashSet<string> categoriesList = new HashSet<string>(); 

            foreach (var movie in movieList)
            {
                categoriesList.Add(movie.Category);
            }

            return categoriesList.ToList();
        }
    }
}
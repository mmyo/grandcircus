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
                        Menu.SearchMoviesByCategory(movieList, Menu.ChooseMovieCategoryMenu());
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

        public static HashSet<string> InitializeCategoriesList(List<Movie> movieList)
        {
            HashSet<string> categoriesList = new HashSet<string>();

            Menu.UpdateMoviesCategoriesList(movieList, categoriesList);

            return categoriesList;

        }
    }
}
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

            switch (Menu.DisplayMainMenu())
            {
                case 1: //see all movies
                    Menu.SeeAllMovies(movieList);
                    break;
                case 2: //see all movies in category
                    Menu.SeeAllMovies(movieList, Menu.ChooseMovieCategoryMenu());
                    break;
                case 3: //add movie
                    Menu.AddMovieMenu(movieList);
                    Menu.SeeAllMovies(movieList);
                    break;
                case 4: //exit
                    Console.WriteLine("Bye");
                    break;          
                default:
                    Console.WriteLine("Did not understand. Bye.");
                    break;
            }
            Console.ReadLine();
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

    }
}

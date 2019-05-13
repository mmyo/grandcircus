using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab11_movies
{
    public class Movie
    {
        //private string _title;

        //private string _category;

        public Movie(string title, string category, int year)
        {
            Title = title;
            Category = category;
            Year = year;
        }

        public string Title { get; set; }

        public string Category { get; set; }

        public int Year { get; set; }

    }
}

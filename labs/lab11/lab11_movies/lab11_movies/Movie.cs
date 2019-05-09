using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_movies
{
    public class Movie
    {
        private string _title;

        private string _category;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string Title { get; set; }

        public string Category { get; set; }

    }
}

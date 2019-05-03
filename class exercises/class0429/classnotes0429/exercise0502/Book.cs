using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0502
{
    public abstract class BookBase
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetGenre()
        {
            return "book";
        }
    }
}

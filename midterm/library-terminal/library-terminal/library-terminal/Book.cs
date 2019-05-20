using System;
using System.Collections.Generic;
using System.Text;

namespace library_terminal
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Enum Status { get; set; }

        public DateTime DueDate { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace classExercises0603_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            //dictionaries

            var books = new List<Book>
            {
                new Book {Author = "another", Title = "title"}
            };

            // add some books
            books.Add(new Book { Author = "me", Title = "My life" });
            books.Add(new Book { Author = "adam", Title = "His life" });
            books.Add(new Book { Author = "our class", Title = "Our life" });

            //for each, loop through to find - O(n)

            //dictionary
            var betterBooks = new Dictionary<string, Book>();
            betterBooks.Add("My Life", new Book { Author = "me", Title = "My life" });

            //
            var myBook = betterBooks["My LIfe"];

            // queues (FIFO)
            var myQueue = new Queue<Book>();
            myQueue.Enqueue(new Book());
            myQueue.Peek();
            

            // stack (LIFO)
            var pringles = new Stack<string>();
            pringles.Push("sour cream and onion");
            pringles.Push("cheddar");

            pringles.Pop();

            Console.ReadLine();
        }

        public class Book
        {
            public string Author { get; set; }

            public string Title { get; set; }


        }
    }
}

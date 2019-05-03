using System;
using System.Collections.Generic;

namespace exercise0502
{
    class Program
    {
        static void Main(string[] args)
        {
            //application that returns a list of books, subgenres child classes. 
            //base book class 

            var book1 = new Horror();
            book1.Title = "Scariest Book Ever";
            var book2 = new Mystery();
            book2.Title = "Who Dunit?";
            var book3 = new NonFiction();
            book3.Title = "Real Story, Promise";
            var book4 = new SciFi();
            book4.Title = "Outer Space Stuff";

            var bookList = new List<BookBase>();

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);

            var bookList2 = new List<BookBase>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Pick a genre: ");
            //    var userGenre = Console.ReadLine();
            //    switch (userGenre)
            //    {
            //        case "horror":
            //            bookList2.Add(new Horror());
            //            break;
            //        case "mystery":
            //            bookList2.Add(new Mystery());
            //            break;
            //        case "nonfiction":
            //            bookList2.Add(new NonFiction());               
            //            break;
            //        case "scifi":
            //            bookList2.Add(new SciFi());
            //            break;
            //        default:
            //            break;
            //    }
            //}

            foreach (var book in bookList)
            {

                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Genre: {book.GetType().Name}");
                //Console.WriteLine($"Genre: {typeof(book)}");

                Console.WriteLine();
            }

            foreach (var book in bookList2)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Genre: {book.GetGenre()}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace library_terminal
{
    public class LibraryApp
    {
        public static void Run()
        {
            var bookList = BookInventory.CreateInventoryList(BookInventory.ImportFileToString());

            DisplayAllBooks(bookList);
            Console.ReadLine();
            CheckOutBook(bookList[1]);
            Console.ReadLine();

            Console.Write("Search for author: ");         
            DisplayAllBooks(SearchBooksByAuthor(bookList, Console.ReadLine()));

            Console.Write("Search by title: ");
            DisplayAllBooks(SearchBooksByTitle(bookList, Console.ReadLine()));
          
        }

        public static void DisplayAllBooks(List<Book> bookList)
        {
            foreach (var book in bookList)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Status);
                Console.WriteLine(book.DueDate);
            }
        }

        public static void CheckOutBook(Book book)
        {
            book.Status = BookStatus.CheckedOut;
            book.DueDate = book.DueDate.AddDays(30);

            Console.WriteLine($"{book.Title} has been checked out. Due Date: {book.DueDate}");

            //return DateTime.Today;
        }


        public static List<Book> SearchBooksByAuthor(List<Book> bookList, string authorSearch)
        {
            var booksByAuthorSearchResults = new List<Book>();

            foreach (var book in bookList)
            {
                if (authorSearch.Equals(book.Author, StringComparison.OrdinalIgnoreCase))
                {
                    booksByAuthorSearchResults.Add(book);
                }
            }

            return booksByAuthorSearchResults;
        }

        public static List<Book> SearchBooksByTitle(List<Book> bookList, string titleSearch)
        {
            var booksByTitleSearchResults = new List<Book>();

            foreach (var book in bookList)
            {
                if (book.Title.Contains(titleSearch, StringComparison.OrdinalIgnoreCase))
                {
                    booksByTitleSearchResults.Add(book);
                }
            }

            return booksByTitleSearchResults;
        }

        public static void ReturnBook(Book book)
        {
            book.Status = BookStatus.OnShelf;
            Console.WriteLine($"{book.Title} has been returned.");
        }

        public static void UpdateBookFile()
        {

        }
    }
}

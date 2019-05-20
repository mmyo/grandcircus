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
            foreach (var book in bookList)
            {
                Console.WriteLine(book.Title);
            }
        }

        public DateTime CheckOutBook(Book book)
        {
            return DateTime.Today;
        }

        public List<Book> DisplayAllBooks()
        {
            var allBooksList = new List<Book>();

            return allBooksList;
        }

        public List<Book> SearchBooksByAuthor()
        {
            var booksByAuthorSearchResults = new List<Book>();

            return booksByAuthorSearchResults;
        }

        public List<Book> SearchBooksByTitle()
        {
            var booksByTitleSearchResults = new List<Book>();

            return booksByTitleSearchResults;
        }

        public static void ReturnBook()
        {

        }

        public static void UpdateBookFile()
        {

        }
    }
}

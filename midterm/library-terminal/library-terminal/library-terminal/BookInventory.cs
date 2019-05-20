using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace library_terminal
{
    public class BookInventory
    {
        public static string ImportFileToString()
        {
            string entireFileString = null;
            try
            {
                // Open the text file using a stream reader.
                using (StreamReader stream = new StreamReader("BookFile.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    entireFileString = stream.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return entireFileString;
        }


        public static List<Book> CreateInventoryList(string inventoryString)
        {
            var inventoryList = new List<Book>();
            var result = inventoryString.Split(new string[] { "\n" }, StringSplitOptions.None);

            foreach (var item in result)
            {
                var bookDetail = item.Split(",");
                var book = new Book();
                book.Title = bookDetail[0];
                book.Author = bookDetail[1];
                //book.Status = Enum.Parse(BookStatus, bookDetail[2]);
                inventoryList.Add(book);
            }
            return inventoryList;

        }
    }
}

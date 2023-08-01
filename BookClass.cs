using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_23_Assign__20
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
    }

    class Library
    {
        static List<Book> books;

        public Library()
        {
            books = new List<Book>();          
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("All Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
        }

        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book ID not found.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}

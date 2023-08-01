using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _1_8_23_Assign__20
{
     class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choiceStr = Console.ReadLine();

                if (!int.TryParse(choiceStr, out int choice))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = true
                        };
                        library.AddBook(newBook);
                        Console.WriteLine("Book added successfully!");
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Book Title: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
    


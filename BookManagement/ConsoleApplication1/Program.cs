using System;

namespace ConsoleApplication1
{
   class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Book Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddBook(bookManager);
                        break;
                    case "2":
                        ViewAllBooks(bookManager);
                        break;
                    case "3":
                        UpdateBook(bookManager);
                        break;
                    case "4":
                        DeleteBook(bookManager);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        static void AddBook(BookManager bookManager)
        {
            Console.Clear();
            Book newBook = new Book();

            Console.Write("Enter Book ID: ");
            newBook.ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            newBook.Name = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            newBook.Author = Console.ReadLine();

            Console.Write("Enter Year of Publication: ");
            newBook.year = Convert.ToInt32(Console.ReadLine());

            bookManager.AddBook(newBook);
            Console.WriteLine("Book added successfully!");
            Console.ReadKey();
        }

        static void ViewAllBooks(BookManager bookManager)
        {
            Console.Clear();
            var books= bookManager.viewBooks();

            if (books.Count > 0)
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.ID}, Title: {book.Name}, Author: {book.Author}, Year: {book.year}");
                }
            }
            else
            {
                Console.WriteLine("No books available.");
            }

            Console.ReadKey();
        }

        static void UpdateBook(BookManager bookManager)
        {
            Console.Clear();
            Console.Write("Enter Book ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var book = bookManager.GetBookById(id);

            if (book != null)
            {
                Console.Write("Enter New Title: ");
                book.Name= Console.ReadLine();

                Console.Write("Enter New Author: ");
                book.Author = Console.ReadLine();

                Console.Write("Enter New Year of Publication: ");
                book.year = Convert.ToInt32(Console.ReadLine());

                bookManager.UpdateBook(book);
                Console.WriteLine("Book updated successfully!");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            Console.ReadKey();
        }

        static void DeleteBook(BookManager bookManager)
        {
            Console.Clear();
            Console.Write("Enter Book ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bookManager.DeleteBookbyID(id);
            Console.WriteLine("Book deleted successfully!");

            Console.ReadKey();
        }
    }
}
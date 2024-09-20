
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book); // Correctly add the book to the list
            Console.WriteLine($"{book.Name} has been added.");
        }

        public List<Book> viewBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            // Use LINQ to find the book by ID
            Book book = books.FirstOrDefault(b => b.ID == id);

            if (book == null)
            {
                // Inform the user that no book was found
                Console.WriteLine("No book found with the given ID.");
                return null;
            }
            else
            {
                // Return the found book
                return book;
            }
        }


        public void DeleteBook(Book book)
        {
            // Check if the book exists in the list before removing it
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine($"{book.Name} has been deleted.");
            }
            else
            {
                Console.WriteLine($"{book.Name} not found.");
            }
        }

        public void DeleteBookbyID(int id)
        {
            var book = GetBookById(id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public void UpdateBook(Book updatedBook)
        {
            var book = GetBookById(updatedBook.ID);
            if (book != null)
            {
                book.Name = updatedBook.Name;
                book.Author = updatedBook.Author;
                book.year = updatedBook.year;
            }
        }
    }
}


    
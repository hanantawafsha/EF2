using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
   public class User : Person
    {
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();


        public User(int id, string name) : base(id, name)
        {
        
        
        }


        public override void DisplayInfo()
        {
            // implement it 
            Console.WriteLine($"User ID: {Id}, Name: {Name}");

        }
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"Book '{book.Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"Book '{book.Title}' has been returned.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' was not borrowed by this user.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
                return;
            }

            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowedBooks)
            {
                // Console.WriteLine($"- {book.Title}");
                book.DisplayInfo();


            }
        }

    }
}

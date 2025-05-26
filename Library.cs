using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Person> Members { get; set; } = new List<Person>(); // AbstractPerson = Person in your setup


        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to library.");
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
            Console.WriteLine($"Member '{member.Name}' added to library.");
        }


        public Book? FindBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.ID == id)
                    return book;
            }
            return null;
        }

        public Person? FindMemberById(int id)
        {
            foreach (var member in Members)
            {
                if (member.Id == id)
                    return member;
            }
            return null;
        }


        public void DisplayAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }

        public void DisplayAllMembers()
        {
            if (Members.Count == 0)
            {
                Console.WriteLine("No members in the library.");
                return;
            }

            foreach (var member in Members)
            {
                member.DisplayInfo();
            }
        }
    }

}


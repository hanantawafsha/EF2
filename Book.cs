using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
   public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book (int ID, string Title, string AuthorName)
        {
            this.ID = ID;
            this.Title = Title;
            this.AuthorName = AuthorName;
        }
        public void DisplayInfo()
        {
            // to implement it
            string status = IsAvailable ? "Available" : "Not Available";

            Console.WriteLine($"Book ID: {ID}, Title: {Title}, Author: {AuthorName}, Status: {status}");

        }
    }
}

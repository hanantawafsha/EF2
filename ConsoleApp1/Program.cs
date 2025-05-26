using ConsoleApp1.Data;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var user = new User
            {
                Name = "Hanan Tawafsha",
                Email = "hanan@gmail.com",
                Password = "hanan1992",
                Blogs = new List<Blog>
        {
            new Blog { Title = "Blog 1", Description = "Description 1" },
            new Blog { Title = "Blog 2", Description = "Description 2" },
            new Blog { Title = "Blog 3", Description = "Description 3" },
            new Blog { Title = "Blog 4", Description = "Description 4" },
            new Blog { Title = "Blog 5", Description = "Description 5" },
        }
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class User
    {
        // id , name , email , password 
        public int UserId { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string Email { get; set; }
        [Column(TypeName = "varchar(12)")]

        public string Password { get; set; }
        public ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    }
}

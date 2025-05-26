using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   public class Blog
    {
        // [ id , title , description ]
        public  int BlogId {  get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string? Description { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}

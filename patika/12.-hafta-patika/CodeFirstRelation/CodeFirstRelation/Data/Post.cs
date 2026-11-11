using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Data
{
    public class Post
    {
        public  int  Id { get; set; }
        public string Title { get; set; } = "";

        public string Content { get; set; } = "";
        public  int  UserId { get; set; }

        public User user { get; set; } = null!;
    }
}

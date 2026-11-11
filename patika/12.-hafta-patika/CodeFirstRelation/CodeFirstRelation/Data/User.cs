using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Data
{
    public class User
    {
        public  int  Id { get; set; }

        public string UserName { get; set; } = "";

        public string Email { get; set; } = "";

        public List<Post> Post { get; set; } = new();
    }
}

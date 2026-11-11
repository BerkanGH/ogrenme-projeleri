using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrack
{
   

    abstract class Employee
    {
        // Ortak özellikler
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        // Abstract metod (her alt sınıf bunu implement etmek zorunda)
        public abstract void Gorev();
    }

}

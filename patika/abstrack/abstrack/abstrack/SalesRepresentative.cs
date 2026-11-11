using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrack
{
    class SalesRepresentative : Employee
    {
        public SalesRepresentative(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Satış temsilcisinin görevi
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} satış temsilcisi olarak çalışıyorum.");
        }
    }

}

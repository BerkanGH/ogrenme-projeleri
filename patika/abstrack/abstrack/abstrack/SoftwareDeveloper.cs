using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrack
{
    class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Yazılımcının görevi
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} yazılım geliştiricisi olarak çalışıyorum.");
        }
    }

}

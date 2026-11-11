using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrack
{
    class ProjectManager : Employee
    {
        public ProjectManager(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Proje yöneticisisinin görevi
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} proje yöneticisi olarak çalışıyorum.");
        }
    }

}

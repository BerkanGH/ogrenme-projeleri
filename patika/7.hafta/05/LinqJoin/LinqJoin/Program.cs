using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }
}

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}

class Program
{
    static void Main()
    {
        // Öğrencileri ekledik
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Veli", ClassId = 1 },
            new Student { StudentId = 3, StudentName = "Ayşe", ClassId = 2 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 2 },
            new Student { StudentId = 5, StudentName = "Mehmet", ClassId = 3 }
        };

        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Fen" },
            new Class { ClassId = 3, ClassName = "Edebiyat" }
        };

        // Group Join işlemi ile grupladık
        var query = from c in classes
                    join s in students on c.ClassId equals s.ClassId into studentGroup
                    select new
                    {
                        ClassName = c.ClassName,
                        Students = studentGroup.Select(s => s.StudentName)
                    };

        // Sonuçları ekrana yazdırıyoruz
        foreach (var item in query)
        {
            Console.WriteLine($"Sınıf: {item.ClassName}");
            if (item.Students.Any())
            {
                Console.WriteLine("Öğrenciler:");
                foreach (var student in item.Students)
                {
                    Console.WriteLine($"- {student}");
                }
            }
            else
            {
                Console.WriteLine("Öğrenci yok.");
            }
            Console.WriteLine();
        }
    }
}

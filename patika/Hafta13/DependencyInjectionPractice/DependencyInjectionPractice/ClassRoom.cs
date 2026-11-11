using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPractice
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        // Constructor Injection ile Ogretmen instance'ı alıyoruz
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        // Teacher nesnesinin GetInfo() metodu üzerinden ogretmen bilgilerini döndüren metot
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}

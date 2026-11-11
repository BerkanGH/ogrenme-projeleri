using DependencyInjectionPractice;

class Program
{
    static void Main()
    {
        // Öncelikle bir Ogretmen instance'ı oluşturuyoruz
        ITeacher teacher = new Teacher("Burak", "Can");

        // ClassRoom sınıfını oluştururken oluşturduğumuz Ogretmen instance'ını constructor'a geçiyoruz
        ClassRoom classroom = new ClassRoom(teacher);

        // ClassRoom sınıfının GetTeacherInfo() metodu üzerinden ogretmen bilgilerini alıp ekrana yazdırıyoruz
        Console.WriteLine("Öğretmen Bilgileri:");
        Console.WriteLine(classroom.GetTeacherInfo());
    }
}
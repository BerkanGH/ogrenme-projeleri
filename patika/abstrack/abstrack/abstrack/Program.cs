using abstrack;

class Program
{
    static void Main(string[] args)
    {
        // Nesneleri oluşturduk
        Employee emp1 = new SoftwareDeveloper("Hasan", "Çıldırmış", "Yazılım");
        Employee emp2 = new ProjectManager("Ayşe", "Kara", "Proje Yönetimi");
        Employee emp3 = new SalesRepresentative("Mehmet", "Yılmaz", "Satış");

        // Metodları kullandık

        emp1.Gorev(); // Yazılım geliştiricisi
        emp2.Gorev(); // Proje yöneticisi
        emp3.Gorev(); // Satış temsilcisi
    }
}

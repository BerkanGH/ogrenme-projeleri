using System;

namespace Patikaconst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default Constructor ile bebek nesnesi oluşturdum
            Bebek bebek1 = new Bebek();
            bebek1.Ad = "Mehmet";
            bebek1.Soyad = "Yılmaz";

            // Parametreli Constructor ile bebek nesnesi oluşturdum
            Bebek bebek2 = new Bebek("Pelin", "Selçuk");

            // Bilgilerin konsola yazdırılması
            Console.WriteLine("Bebek 1 Bilgileri:");
            bebek1.bilgileriGöster();

            Console.WriteLine("\nBebek 2 Bilgileri:");
            bebek2.bilgileriGöster();

            Console.ReadLine();
        }
    }
}

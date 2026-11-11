using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçilerin isimlerini içeren bir liste oluşturuyoruz.
        List<string> ziyaretciler = new List<string>
        {
            "Lionel Messi",
            "Cristiona Ronaldo",
            "Maldini",
            "Xavi",
            "Neymar",
            "Tayfur Bingöl",
            "Ali koç"
        };

        // Liste içindeki her ismi ekrana yazdırmak için foreach döngüsü kullanıyoruz.
        Console.WriteLine("Patika Plus Gala Gecesine Hoşgeldiniz");
        Console.WriteLine("Davetli listemiz:");
        int index = 1;
        foreach (string davetlilistesi in ziyaretciler)
        {
            Console.WriteLine($"{index}) {davetlilistesi}");
            index++;
        }
    }
}

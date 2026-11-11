using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // liste oluşturcaz önce
        List<string> kahveler = new List<string>();

        Console.WriteLine("5 tane kahve giriniz");

     
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}. kahve ismini girin: ");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve); // Girilen ismi listeye ekliyoruz.
        }

        int sıralama = 1;
        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine($"{sıralama}) {kahve}"); 


        }
    }
}

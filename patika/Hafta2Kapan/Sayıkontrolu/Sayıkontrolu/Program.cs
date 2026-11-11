using System;


namespace Sayıuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba bir sayı giriniz");
            string sayi = Console.ReadLine();

            int number = int.Parse(sayi);

            if (number > 10)
            {

                Console.WriteLine("sayi 10 dan büyük");


            }
            else if (number < 10)
            {

                Console.WriteLine("sayı 10 dan küçük");


            }

            else {
                Console.WriteLine("sayı 10 a eşit");
            
            
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("sayi 2 ye bölünüyor");


            }

            else {
                Console.WriteLine("sayı ikiye bölünmüyor");   
            
            }
        }
    }

}
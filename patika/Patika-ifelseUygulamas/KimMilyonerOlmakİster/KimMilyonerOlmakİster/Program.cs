using System;
using System.ComponentModel.Design;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 2;
           

                Console.WriteLine("Yarışmaya hoşgeldiniz 3 soruluk bilgi yarışması başlıyor");
                Console.WriteLine("ilk sorunuz: " + " 1 -> Kızınca tüküren hayvan hangisidir ?\r\n\r\n a) Lama b) Deve ");
                string cevap = Console.ReadLine();
            if (cevap == "a")
            {
                Console.WriteLine("tebrikler doğru cevapladınız");


            }
            else
            {
                hak--;
                Console.WriteLine("yanlış cevapladınız kalan hakkınız: " + hak);
            }

            
            Console.WriteLine("İkinci sorunuz: " + " 2 -> Dünya'ya en yakın gezegen hangisidir ? \r\n\r\na) Venüs b) Mars ");
            string ikincicevap = Console.ReadLine();
            if (ikincicevap == "b")
            {
                Console.WriteLine("tebrikler doğru cevap");


            }
             else { hak--;
                Console.WriteLine("yanlış cevapladınız");
            }

            if (hak == 2)
            {
                Console.WriteLine("tebrikler yarışmayı kazandınız");

            }
            else if (hak == 1) {
                Console.WriteLine("son sorunuz: " + "3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? \r\n\r\na) 7 b) 12 \r\n\r\n");
                string soncevap = Console.ReadLine();
                if (soncevap == "b") {
                    Console.WriteLine("yarışmayı kazandınız tebrikler");



                }
                else Console.WriteLine("yarışmayı kaybettiniz");

            }
            else Console.WriteLine("yarışmayı kaybetiniz");

        }
    }
}
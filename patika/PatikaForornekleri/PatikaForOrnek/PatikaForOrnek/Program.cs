using System;

namespace OrnekNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // for örnekleri ilki  Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırıcam
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            // ikinci örnek 1 ile 20 arasındaki sayıları bastırdım

            for (int i = 1; i < 20; i++) {

                Console.WriteLine(i);
            }
            // üçüncü örnek çift sayıları bastırıyorum.
            for (int i = 0; i < 20; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }

            // dördüncü örnek sayıların toplamı ilk başta toplama 0 değerini döngü dışında veriyorum. Döngü içerisinde 0 değerini verseydim her döngüde tekrardan 0 a eşitlenirdi.
            int toplam =0;

            for (int i = 50; i < 150; i++)
            {
                toplam += i;
                if (i == 149) {
                    Console.WriteLine("toplam sonuç " + toplam);
                }

            }

            // son örnek
            int ciftoplam = 0;
            int tektoplam = 0;
            for (int i = 0; i < 120; i++)
            {
                if ((i % 2) == 0)
                {

                    ciftoplam += i;
                    if (i == 118)
                    {
                        Console.WriteLine("çift sayıların toplamı : " + ciftoplam);
                    }
                }

                if ((i % 2) == 1) { 
                tektoplam += i;
                    if (i == 119) {
                        Console.WriteLine("tek sayıların toplamı: " + tektoplam);
                    
                    }

                
                }

            }



        }
    }
}

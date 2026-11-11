using System;

class Program
{
    static void Main()
    {
        // 1. 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazısı
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            count++;
        }

        Console.WriteLine(); 

        // 2. 1 ile 20 arasındaki sayıları yazdırınız.
        int number = 1;
        while (number <= 20)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine(); 

        // 3. 1 ile 20 arasındaki çift sayıları yazdırınız.
        number = 1;
        while (number <= 20)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
            number++;
        }

        Console.WriteLine(); 

        // 4. 50 ile 150 arasındaki sayıların toplamını yazdırınız.
        int toplam = 0;
        number = 50;
        while (number <= 150)
        {
            toplam += number;
            number++;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

        Console.WriteLine(); 

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı yazdırınız.
        int tekToplam = 0;
        int ciftToplam = 0;
        number = 1;
        while (number <= 120)
        {
            if (number % 2 == 0)
            {
                ciftToplam += number;
            }
            else
            {
                tekToplam += number;
            }
            number++;
        }
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
    }
}

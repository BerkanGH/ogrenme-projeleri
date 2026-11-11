using System;

class Program
{
    static void Main()
    {
        // bu if ile olan

        Console.WriteLine("Rüya manavına hoşgeldin. Meyvelerimizin fiyatı: \r\n\r\n" +
            "Elma = 2 TL\r\n\r\n" +
            "Armut = 3 TL\r\n\r\n" +
            "Çilek = 2 TL\r\n\r\n" +
            "Muz = 3 TL\r\n\r\n" +
            "Diğer bütün meyveler = 4 TL" +"");
        
        
        Console.WriteLine("Hangi meyveyi satın almak istiyorsunuz?");
        string meyve = Console.ReadLine().ToLower(); // Büyük küçük harf duyarlılığını kaldırıyoruz.

        if (meyve == "elma")
        {
            Console.WriteLine("Elma: 2 TL");
        }
        else if (meyve == "armut")
        {
            Console.WriteLine("Armut: 3 TL");
        }
        else if (meyve == "çilek")
        {
            Console.WriteLine("Çilek: 2 TL");
        }
        else if (meyve == "muz")
        {
            Console.WriteLine("Muz: 3 TL");
        }
        else
        {
            Console.WriteLine($"{meyve}: 4 TL");
        }
        //  Simdi switch case ile olan

        
        Console.WriteLine("Hangi meyveyi satın almak istiyorsunuz?");
        string meyveswitchcase = Console.ReadLine().ToLower(); // Büyük küçük harf duyarlılığını yine ortadan kaldırdık.

            switch (meyveswitchcase)
            {
                case "elma":
                    Console.WriteLine("Elma: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Armut: 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Çilek: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Muz: 3 TL");
                    break;
                default:
                    Console.WriteLine($"{meyveswitchcase}: 4 TL");
                    break;
            }
        }
    }






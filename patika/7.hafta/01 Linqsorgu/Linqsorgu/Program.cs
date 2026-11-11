using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

    // random nesnesi oluşturup 10 tane sayı oluşturduk. 
        
        Random rand = new Random();
        List<int> sayilar = new List<int>();

        for (int i = 0; i < 10; i++)
        {

            sayilar.Add(rand.Next(-10, 10));



        }

        // bizden istenilenler için tek tek sorgu yapıyoruz. 

        
        Console.WriteLine("çift sayilar");

        var çiftsayilar = sayilar.Where(x => x % 2 == 0).ToList();

        foreach (var x in çiftsayilar)
        {

            Console.WriteLine(x);
        }

        Console.WriteLine("*******************");

        Console.WriteLine("tek sayilar");

        var tektsayilar = sayilar.Where(x => x % 2 != 0).ToList();

        foreach (var x in tektsayilar)
        {

            Console.WriteLine(x);


        }
        Console.WriteLine("*******************");

        Console.WriteLine("negatif sayilar");

        var negatifsayilar = sayilar.Where(x => x < 0).ToList();

        foreach (var x in negatifsayilar)
        {

            Console.WriteLine(x);



        }
        Console.WriteLine("*******************");

        Console.WriteLine("çift sayilar");

        var pozitifsayilar = sayilar.Where(x => x > 0).ToList();

        foreach (var x in pozitifsayilar)
        {

            Console.WriteLine(x);

        }
        Console.WriteLine("*******************");

        Console.WriteLine("15ten büyük 22 den küçükler");

        var koşullusayilar = sayilar.Where(x => x > 15 && x < 22);

        foreach (var x in koşullusayilar)
        {

            Console.WriteLine(x);

        }
        Console.WriteLine("*******************");


        Console.WriteLine("kareler");

        var kare = sayilar.Select(x => x * x).ToList();

        foreach (var x in kare)
        {

            Console.WriteLine(x);

        }
    }
}
       

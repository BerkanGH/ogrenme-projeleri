using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

public class Singer
{
    public string Singername { get; set; }
    public string müziktürü { get; set; }

    public int cıkısyılı { get; set; }

    public int satıssayisi {  get; set; }

}


class Program
{
    static void Main(string[] args) {


        // verileri ekledik

        List<Singer> sarkıcı = new List<Singer>()
        {

            new Singer() {Singername = "Ajda Pekkan", müziktürü = "Pop", cıkısyılı = 1968, satıssayisi = 20000000 },
            new Singer { Singername = "Sezen Aksu", müziktürü = "Türk Halk Müziği / Pop", cıkısyılı = 1971, satıssayisi = 10000000 },
            new Singer { Singername = "Funda Arar", müziktürü = "Pop", cıkısyılı = 1999, satıssayisi = 3000000 },
            new Singer { Singername = "Sertab Erener", müziktürü = "Pop", cıkısyılı = 1994, satıssayisi = 5000000 },
            new Singer { Singername = "Sıla", müziktürü = "Pop", cıkısyılı = 2009, satıssayisi = 3000000 },
            new Singer { Singername = "Serdar Ortaç", müziktürü = "Pop", cıkısyılı = 1994, satıssayisi = 10000000 },
            new Singer { Singername = "Tarkan", müziktürü = "Pop", cıkısyılı = 1992, satıssayisi = 40000000 },
            new Singer { Singername = "Hande Yener", müziktürü = "Pop", cıkısyılı = 1999, satıssayisi = 7000000 },
            new Singer { Singername = "Hadise", müziktürü = "Pop", cıkısyılı = 2005, satıssayisi = 5000000 },
            new Singer { Singername = "Gülben Ergen", müziktürü = "Pop / Türk Halk Müziği", cıkısyılı = 1997, satıssayisi = 10000000 },
            new Singer { Singername = "Neşet Ertaş", müziktürü = "Türk Halk Müziği / Türk Sanat Müziği", cıkısyılı = 1960, satıssayisi = 2000000 }



        };

        // s ile başlayanlar için sorgu

        var silebaslayan = sarkıcı.Where(x=> x.Singername.StartsWith("S")).ToList();
        Console.WriteLine("s ile başlayanlar");

        foreach(var s in silebaslayan)
        {

            Console.WriteLine($" {s.Singername}  {s.müziktürü}  {s.cıkısyılı}  {s.satıssayisi}");
        }

        Console.WriteLine("-----------------------------");

        // 10 milyondan çok satanlara sorgu

        Console.WriteLine("10 milyondan çok satanlar");
        var albümsatış = sarkıcı.Where(x=> x.satıssayisi>10000000).ToList();

        foreach (var s in albümsatış)
        {
            Console.WriteLine($" {s.Singername}  {s.müziktürü}  {s.cıkısyılı}  {s.satıssayisi}");
        }

        Console.WriteLine("-------------------------------");

        Console.WriteLine("2000 yılı öncesi çıkanlar ve pop");

        //2000 yılı öncesinde çıkan pop şarkıları için sorgu

        var popikibin = sarkıcı.Where(x=>x.cıkısyılı<2000 && x.müziktürü.Contains("Pop"))
                               .OrderBy(x=>x.Singername)
                               .GroupBy(x=>x.cıkısyılı)
                               .ToList();
        foreach (var group in popikibin)
        {
            Console.WriteLine($"cıkıs yılı: {group.Key}");

            foreach (var s in group)
            {
                Console.WriteLine($" {s.Singername}  {s.müziktürü}  {s.cıkısyılı}  {s.satıssayisi}");


            }




        }
        Console.WriteLine("----------------");

        Console.WriteLine("en çok albüm satan");


        // en çok albüm satanları için. Orderby ile sıralayıp first metodu ile sadece ilkini alarak en çok satanı buluyoruz. Aynmısını en yeni için orderbydescending kullanarak yaptım.

        var encoksatan = sarkıcı.OrderByDescending(x => x.satıssayisi).First();

        Console.WriteLine(encoksatan.Singername);

        Console.WriteLine("----------------");

        Console.WriteLine("en yeni şarkıcı");

        var enyeni = sarkıcı.OrderByDescending(x => x.cıkısyılı).First();

        Console.WriteLine(enyeni.Singername);

        var eneski = sarkıcı.OrderBy(x => x.cıkısyılı).First();

        Console.WriteLine("------------");

        Console.WriteLine("en eski şarkıcı");

        Console.WriteLine(eneski.Singername);








    }








}


        
          
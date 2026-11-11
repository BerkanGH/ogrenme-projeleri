using System;
using System.Collections.Generic;

class Film
{


    // istedikleri property leri belirliyoruz.
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    // constructor tanımladık

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmler = new List<Film>();
        string devam;

        do
        {
            // Kullanıcıdan film ismi ve imdb puanı alıyoruz.
            Console.Write("Film ismini girin: ");
            string filmIsmi = Console.ReadLine();

            Console.Write("IMDB puanını girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
            {
                Console.Write("Lütfen 0 ile 10 arasında bir IMDB puanı girin: ");
            }

            // Yeni film nesnesi oluşturup listeye ekledik.
            filmler.Add(new Film(filmIsmi, imdbPuani));

            // Yeni film istiyor mu diye soruyoruz. Evet derse tekrar döngüye girecek.
            Console.Write("Başka bir film eklemek ister misiniz? (evet/hayır): ");
            devam = Console.ReadLine().ToLower();

        } while (devam == "evet");

        // Bilgileri listediledik.
        Console.WriteLine("\nBütün Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        // 4 ile 9 arasında sorgu yapıp onu da listeledik.

        Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }

        //a ile başlayanları da listeledik.

        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }
    }
}

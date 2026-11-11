using patikaflix;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // diziler ve komedidizileri diye iki liste oluşturduk. bunlar sınıflardan geliyor

        List<Dizi> diziler = new List<Dizi>();
        List<KomediDizi> komedidizileri = new List<KomediDizi>();

        Console.WriteLine("merhaba hoşgeldiniz");
        
        // döndüyle başlıyoruz kullanıcı e ye tıklamazsa döngüden çıkılcak

        while (true) {
            Console.WriteLine("yeni dizi eklemek için e ye basınız. e ye basmadığınızda çıkış yapılacak");

            string kullanicicevap = Console.ReadLine();

            if (kullanicicevap != "e") {

                break;

            }

            // bilgileri alıyoruz

            Console.WriteLine("dizinin adını giriniz");
            string diziad = Console.ReadLine();
            
            Console.WriteLine("yapim yılını giriniz");
            int yapimyılı = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("türünü giriniz");
            string dizitürü = Console.ReadLine();
           
            Console.WriteLine("yayim tarihini giriniz");
            int yayimtarihi= Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("yönetmeni giriniz");
            string yönetmenler = Console.ReadLine();
           
            Console.WriteLine("ilk platformu giriniz");
            string ilkplatform = Console.ReadLine();

            // diziler listesine ekliyoruz


            Dizi yenidizi = new Dizi(diziad, yapimyılı, dizitürü, yayimtarihi, yönetmenler, ilkplatform);
            diziler.Add(yenidizi);

            Console.WriteLine("diziniz eklendi");

            Console.WriteLine();

            // eğer komedi türündeyse komedi dizilerine de ekledik

            if (dizitürü.ToLower() == "komedi") {
                
                KomediDizi yenikomedidizi = new KomediDizi(diziad,yönetmenler,dizitürü);
                komedidizileri.Add(yenikomedidizi);

            }
        
        }


        //kullanıcıya bilgileri veriyoruz.

        Console.WriteLine("dizilerinizin tüm özellikleri");

        foreach (var item in diziler)
        {
            Console.WriteLine($"dizi adı: {item.Diziadi} dizi yapim yılı: {item.Yapimyılı} dizitürü: {item.YayimTarihi} yönetmeni: {item.Yonetmenler} ilk platformu {item.IlkPlatform}");
        }

        // komedidizilerini belli bir şekilde gruplandırıp sonra kullancııya gösteriyoruz.


        var komedidizisırası = komedidizileri.OrderBy(x=> x.Diziadi)
                                             .ThenBy(x => x.Yönetmen)
                                             .ToList();
        Console.WriteLine("*********************");
        Console.WriteLine("komedi türündeki dizilerinizin bazı özellikleri");

        foreach (var komedi in komedidizileri)

        {
            Console.WriteLine($"dizi adı: {komedi.Diziadi}  dizitürü: {komedi.Dizitürü} yönetmeni: {komedi.Yönetmen}");
        }






    }
}
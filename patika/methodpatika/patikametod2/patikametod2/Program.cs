using System;

class Program
{
    static void Main()
    {
        // 1. Şarkı sözü yazdıran metot
        Sevdiğimsarkısözüyazdir();

        // 2. Rastgele sayı üretip 2'ye bölümünden kalanı döndüren metot
        int kalan = RastgeleSayiUret();
        Console.WriteLine("Rastgele üretilen sayının 2'ye bölümünden kalan: " + kalan);

        // 3. İki sayının çarpımını döndüren metot
        Console.WriteLine("birinci sayiyi giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci sayiyi giriniz");
        int sayi2 = Convert.ToInt32(Console.ReadLine());    
        int carpimSonucu = CarpimBul(sayi1, sayi2);
        Console.WriteLine($"{sayi1} ve {sayi2} sayıların çarpımı: {carpimSonucu}");

        // 4. İsim ve soyisim bilgilerini alıp hoş geldin mesajı yazdıran metot
        Console.WriteLine("önce ad sonra soy ad giriniz");
        string isim = Console.ReadLine();
        string soyisim = Console.ReadLine(); 
        HosGeldinMesaji(isim, soyisim);
    }

    // Geriye değer döndürmeyen bir void metot
    static void Sevdiğimsarkısözüyazdir()
    {
        Console.WriteLine("Aklıma bir şey gelmedi :D ");
    }

    // Geriye tamsayı döndüren bir metot
    static int RastgeleSayiUret()
    {
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next(0, 100); // 0-99 arası rastgele sayı
        return rastgeleSayi % 2; // 2'ye bölümünden kalanı döndür
    }

    // Parametre alan ve geriye değer döndüren bir metot
    static int CarpimBul(int a, int b)
    {
        return a * b; // İki sayının çarpımını döndür
    }

    // Parametre alan ve geriye değer döndürmeyen bir metot
    static void HosGeldinMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}"); // Hoş geldin mesajı yazdır
    }
}

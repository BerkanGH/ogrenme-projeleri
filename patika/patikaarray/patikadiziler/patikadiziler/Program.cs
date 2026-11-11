using System;

class Program
{
    static void Main()
    {
        // diziyi tanımladım
        int[] sayilar = new int[10];

        // dizinin elemanlarını for döngüsü ile alıyorum
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($" {i + 1}. sayı: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        //burada da dizinin elemanlarını bastırıyoru
        Console.WriteLine("\nDizideki sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        //diziye kullanıcıdan alınan yeni bir değeri ekledik
        Console.Write("\nLütfen 11. sayıyı giriniz giriniz: ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

   
        int[] yeniDizi = new int[sayilar.Length + 1];
        sayilar.CopyTo(yeniDizi, 0);
        yeniDizi[yeniDizi.Length - 1] = yeniSayi;

        // diziyi büyükten küçüğe sıraladık
        Array.Sort(yeniDizi);
        Array.Reverse(yeniDizi);

        Console.WriteLine("\nBüyükten Küçüğe Şekilde sıralama:");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}

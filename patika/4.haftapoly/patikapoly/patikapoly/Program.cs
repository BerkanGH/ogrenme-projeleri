using System;

public abstract class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    protected BaseGeometrikSekil(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public abstract double AlanHesapla();
}

public class Kare : BaseGeometrikSekil
{
    public Kare(double kenarUzunlugu) : base(kenarUzunlugu, kenarUzunlugu)
    {
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; // Kenar uzunluğunun karesi
    }
}

public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik)
    {
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; // Genişlik x Yükseklik
    }
}

public class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double genislik, double yukseklik) : base(genislik, yukseklik)
    {
    }

    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2; // (Genişlik x Yükseklik) / 2
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BaseGeometrikSekil kare = new Kare(5);
        BaseGeometrikSekil dikdortgen = new Dikdortgen(4, 6);
        BaseGeometrikSekil dikUcgen = new DikUcgen(4, 3);

        Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");
    }
}

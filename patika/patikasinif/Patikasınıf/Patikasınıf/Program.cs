using System;

namespace Patikasınıf
{
    class Program
    {
        static void Main(string[] args)
        {
           Person ogrenci1 = new Person();
            ogrenci1.Name = "ali";
            ogrenci1.Soyad = "gürbüz";
            ogrenci1.DogumGunu = new DateTime(2005, 7, 18);

            Person ogretmen1 = new Person();
            ogretmen1.Name = "mehmet";
            ogretmen1.Soyad = "karahanlı";
            ogretmen1.DogumGunu = new DateTime(1960,1,1);

            ogrenci1.bilgileriGöster();
            ogretmen1.bilgileriGöster();


        }
    }
}
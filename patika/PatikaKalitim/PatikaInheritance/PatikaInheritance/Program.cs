using System;

namespace PatikaInheritance {
    class program
    {

        static void Main(string[] args)
        {


            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.ad = "aleyna";
            ogrenci1.soyAd = "arslan";

            ogrenci1.ogrNo = "5135131230";


            ogrenci1.OgrenciBilgileriGöster();






            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.ad = "yağız";
            ogretmen1.soyAd = "can";
            ogretmen1.maas = 35000;

            ogretmen1.OgretmenBilgileriGöster();












        }








        }


}
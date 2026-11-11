using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaInheritance
{
    public class BaseKisi
    {
        public string ad { get; set; }
        public string soyAd { get; set; }

        public string BilgileriGöster()
        {

            return $"adı: {ad} soyadı: {soyAd}";

        }

    }
    public class Ogrenci : BaseKisi

    { 
        public string ogrNo { get; set; }

        public void OgrenciBilgileriGöster() 
           
        
         {
            
            Console.WriteLine($" {BilgileriGöster()} ogrenci no: {ogrNo} "); // bilgileri gösteri kalıtım aldık.
            
        
        
         }

      


     }

    public class Ogretmen : BaseKisi

    {

        public int maas { get; set; }

        public void OgretmenBilgileriGöster()
        {
             
            Console.WriteLine($"{BilgileriGöster()} maaşı: {maas} "); // bilgilerigösteri kalıtımla aldık.
        
        
        }






    }

}

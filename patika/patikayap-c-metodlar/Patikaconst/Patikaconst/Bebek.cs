using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patikaconst
{
    public class Bebek
    {
        private string ad;
        private string soyad;
        private DateTime dogumtarihi;

        public string Ad { get { return ad; } set { ad = value; } }

        public string Soyad { get { return soyad; } set { soyad = value; } }

        public DateTime Dogumtarihi { get { return dogumtarihi; } set { dogumtarihi = value; } }

        //default olan bu
        public Bebek()
        {
            dogumtarihi = DateTime.Now;
            Console.WriteLine("ıngaaaa");

        }
        // 
        public Bebek(string ad, string soyad)
        {

            Ad = ad;
            Soyad = soyad;
            Console.WriteLine("ıngaaaa");




        }


        public void bilgileriGöster()
        {

            Console.WriteLine($"bebeğin adı {ad} bebeğin soyadı {soyad} bebeğin doğum tarihi{dogumtarihi}");


        }

    }
}
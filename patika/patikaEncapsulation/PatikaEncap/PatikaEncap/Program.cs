using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaEncap
{
    class program
    {
        static void Main(string[] args)
        {

            //araba1 için değerleri girdik. Burada kapı sayısı 4 dedik ve herhangi bir hata almadan devam ediyor.

            Araba araba1 = new Araba();

            araba1._marka = "mercedes";
            araba1.KapıSayisi = 4;
            araba1._renk = "siyah";
            araba1._model = "2015 model";


            araba1.BilgileriGöster();

            // burada kapı sayısına 3 dediğmiz için kullanıcıya geri bildirim veriyoruz ve araba.cs de kapısayısını -1 olarakta ayarladık.

            Araba araba2 = new();

            araba2._marka = "audi";
            araba2.KapıSayisi = 3;
            araba2._renk = "lacivert";
            araba2._model = "2020";


            araba2.BilgileriGöster();

            
            

           



        }

    }
}

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

            Araba araba1 = new Araba();

            araba1._marka = "mercedes";
            araba1.KapıSayisi = 4;
            araba1._renk = "siyah";
            araba1._model = "2015 model";


            Araba araba2 = new();

            araba2._marka = "audi";
            araba2.KapıSayisi = 3;
            araba2._renk = "lacivert";
            araba2._model = "2020";


            
            

           



        }

    }
}

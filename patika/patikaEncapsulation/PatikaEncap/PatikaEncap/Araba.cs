using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaEncap
{
    public class Araba
    {

        // araba klasında property leri oluşturduk ardından private olarakta kapısayisinin kontrollü şekilde ayarladım. Eğer 2 ya da 4 girilirse kapısayisi -1 olarak ayarlanacak ve kullanıcıya da mesaj gelcek

        public string _model { get; set; }
        public string _renk { get; set; }
        public string _marka { get; set; }

        private int _kapıSayisi;

        public int KapıSayisi { 
            
            get { return _kapıSayisi;}

            set { if (value == 2 || value == 4)
                {

                    _kapıSayisi = value;

                }
                else
                {
                    Console.WriteLine("kapı sayısı 2 ya da 4 olabilir");
                    _kapıSayisi = -1;
                }
            
            }
        }

        public void BilgileriGöster()
        {

            Console.WriteLine($"modeli : {_model} rengi : {_renk} markası: {_marka} kapı sayısı: {_kapıSayisi} ");

        }


    }
}

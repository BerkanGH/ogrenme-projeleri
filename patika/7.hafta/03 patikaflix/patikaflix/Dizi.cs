using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaflix
{
    public class Dizi
    {
        public string Diziadi { get; set; }
        public int Yapimyılı { get; set; }

        public string Dizitürü { get; set; }

        public int YayimTarihi { get; set; }
        public string Yonetmenler { get; set; }
        public string IlkPlatform { get; set; }


        public Dizi (string diziadi, int yapimy, string dizitürü, int yayimtarihi, string yonetmenler, string ilkplatform)
        {

            Diziadi = diziadi;
            Yapimyılı = yapimy;
            Dizitürü = dizitürü;
            YayimTarihi = yayimtarihi;
            Yonetmenler = yonetmenler; 
            IlkPlatform = ilkplatform;


        }


    }
}

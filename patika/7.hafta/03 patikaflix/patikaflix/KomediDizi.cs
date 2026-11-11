using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaflix
{
    public class KomediDizi
    {
        public string Diziadi { get; set; }

        public string Yönetmen { get; set; }
        public string Dizitürü { get; set; }

        public KomediDizi(string diziadi , string yönetmen, string dizitürü)
        {


            Diziadi = diziadi;
            Yönetmen = yönetmen;
            Dizitürü = dizitürü;

        }

    }

}

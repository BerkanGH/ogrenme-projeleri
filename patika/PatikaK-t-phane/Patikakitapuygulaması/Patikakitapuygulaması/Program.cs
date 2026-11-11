using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikakitapuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu metodda değerleri verip newi de kullanarak nesne oluşturduk. Bunu istediğimiz kadar çoğaltabiliriz.
            Kitap kitap1 = new Kitap("Ay Bahçeleri", "Steve", "Ericson", 720, "ithaki");

            kitap1.KitapBilgileriniGöster();


            Kitap kitap2 = new Kitap();

            kitap2.yazarSoyadı = "Tolkien";
            kitap2.sayfaSayısı = 1000;
            kitap2.kitapAdı = "Yüzüklerin Efendisi";
            kitap2.yazarAdı = "John Ronald Reuel";
            kitap2.basımEvi = "Metis Yayıncılık";


            kitap2.KitapBilgileriniGöster();









        }
    }
}
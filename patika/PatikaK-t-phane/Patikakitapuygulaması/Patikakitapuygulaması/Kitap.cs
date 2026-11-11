using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patikakitapuygulaması
{
     class Kitap
    {
        // kitabın özellikleri ile ilgili bilgiler bunlar.
        public string kitapAdı;
        public string yazarAdı;
        public string yazarSoyadı;
        public int sayfaSayısı;
        public string basımEvi;
        public DateTime kayıtTarihi;

        // bu default olan. Sadece kayıt tarihi o an girilcek.
        public Kitap() { 
        
        kayıtTarihi = DateTime.Now;
 
        
        }

        // bu constructoru kullanmak için nesne oluştururken direkt değerlerin girilmesi gerekiyor.
        public Kitap(string kitapadı, string yazaradı, string yazarsoyadı, int sayfasayısı, string basımevi) {

            kitapAdı = kitapadı;
            yazarAdı = yazaradı;
            yazarSoyadı = yazarsoyadı;
            sayfaSayısı = sayfasayısı;
            basımEvi = basımevi;

            kayıtTarihi = DateTime.Now;
        
        
        }

        public void KitapBilgileriniGöster() {

            Console.WriteLine($"kitabın adı: {kitapAdı} yazaradı: {yazarAdı} yazar soyadı: {yazarSoyadı} sayfasayısı : {sayfaSayısı} basımevi {basımEvi}");
        
        }

    }
}

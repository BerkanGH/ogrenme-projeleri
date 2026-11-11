using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikasınıf
{
    public class Person
    {
        private string name;

        private string soyad;

        private DateTime dogumGunu;

        public string Name { get { return name; } set { name = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }
        public DateTime DogumGunu { get { return dogumGunu; } set { dogumGunu = value; } }

        public void bilgileriGöster() {

            Console.WriteLine($"adı : {name } soyadı: {soyad} doğum günü : {dogumGunu}");
        
        
        }




    }

}

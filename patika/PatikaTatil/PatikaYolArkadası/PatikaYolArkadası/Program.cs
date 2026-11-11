using System;

namespace TatilUygulaması

{
    class Program
    {
        static void Main(string[] args)
        {
            
                       
            Console.WriteLine("Merhaba lütfen tatil seçeneğini seçiniz");

            string menü = "3 adet lokasyonumuz var:\r\n\r\n1 " +
                "- Bodrum (Paket başlangıç fiyatı 4000 TL)\r\n\r\n2 " +
                "- Marmaris (Paket başlangıç fiyatı 3000 TL)\r\n\r\n3 " +
                "- Çeşme (Paket başlangıç fiyatı 5000 TL)";


            string yol = "1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n\r\n2 " +
                       "- Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)";

            while (true) {
                Console.WriteLine(menü);

                string targetsecenek = "çeşme";
                string targetsecenek2 = "bodrum";
                string targetsecenek3 = "marmaris";

                string secenek = Console.ReadLine();

                // burada seçeneklerden birisi için büyük küçük harf duyarlılığını kaldırdım diğerleri içinde aynısını yapıcam.

                if (string.Equals(secenek, targetsecenek, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("çeşmeyi seçtiniz. kaç kişi için tatil düşünüyorsunuz?");

                    string kisisayisi = Console.ReadLine();
                    int kisi = int.Parse(kisisayisi);


                    Console.WriteLine("ulaşım için nasıl bir şey düşünüyorsunuz");

                    Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız" + yol);

                    string yoltercih = Console.ReadLine();
                    if (yoltercih == "1")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 5000 * kisi));

                    }
                    else if (yoltercih == "2")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 5000 * kisi));

                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("lütfen geçerli bir giriş yapınız");
                            Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız " + yol);

                            string userinput = Console.ReadLine();

                            if (userinput == "1")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 5000 * kisi));

                                break;
                            }
                            else if (userinput == "2")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 5000 * kisi));

                                break;

                            }
                            else Console.WriteLine("lütfen geçerli değer giriniz");
                        }


                    }
                 

                    
                    
                    



                }


                else if (string.Equals(secenek, targetsecenek2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("bodrumu seçtiniz. kaç kişi için tatil düşünüyorsunuz?");

                    string kisisayisi = Console.ReadLine();
                    int kisi = int.Parse(kisisayisi);


                    Console.WriteLine("ulaşım için nasıl bir şey düşünüyorsunuz");

                    Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız" + yol);

                    string yoltercih = Console.ReadLine();
                    if (yoltercih == "1")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 4000 * kisi));

                    }
                    else if (yoltercih == "2")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 4000 * kisi));

                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("lütfen geçerli bir giriş yapınız");
                            Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız " + yol);

                            string userinput = Console.ReadLine();

                            if (userinput == "1")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 4000 * kisi));

                                break;
                            }
                            else if (userinput == "2")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 4000 * kisi));

                                break;

                            }
                            else Console.WriteLine("lütfen geçerli değer giriniz");
                        }


                    }
                   



                }


                else if (string.Equals(secenek, targetsecenek3, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("marmarisi seçtiniz. kaç kişi için tatil düşünüyorsunuz?");

                    string kisisayisi = Console.ReadLine();
                    int kisi = int.Parse(kisisayisi);


                    Console.WriteLine("ulaşım için nasıl bir şey düşünüyorsunuz");

                    Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız" + yol);

                    string yoltercih = Console.ReadLine();
                    if (yoltercih == "1")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 3000 * kisi));

                    }
                    else if (yoltercih == "2")
                    {
                        Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 3000 * kisi));

                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("lütfen geçerli bir giriş yapınız");
                            Console.WriteLine("1 ya da 2 diyerek seçiminizi yapınız " + yol);

                            string userinput = Console.ReadLine();

                            if (userinput == "1")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar" + (1500 * kisi + 5000 * kisi));

                                break;
                            }
                            else if (userinput == "2")
                            {
                                Console.WriteLine("toplam ödeyeceğiniz tutar " + (4000 * kisi + 4000 * kisi));

                                break;

                            }
                            else Console.WriteLine("lütfen geçerli değer giriniz");
                        }


                    }
                    



                }

                else {
                    Console.WriteLine("yanlış seçim yaptınız lütfen doğru seçim yapınız");

                    continue; // döngünün başına yolluyorum.
                        
                
                
                }

                while (true)
                {
                    Console.WriteLine("Yeni bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
                    string devam = Console.ReadLine();

                    if (string.Equals(devam, "evet", StringComparison.OrdinalIgnoreCase))
                    {
                        break; 
                    }
                    else if (string.Equals(devam, "hayır", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("İyi günler, bizi tercih ettiğiniz için teşekkürler!");
                        return; // Programdan çıkar
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 'Evet' veya 'Hayır' olarak cevaplayınız.");
                    }
                }



            }




        }
    }
}

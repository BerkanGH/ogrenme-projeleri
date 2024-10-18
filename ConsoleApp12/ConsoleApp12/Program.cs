using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uygulamamıza hoşgeldiniz" +
        "\r\nHangi programı çalıştırmak istersiniz?" +
        "\r\n1 - Rastgele Sayı Bulma Oyunu" +
        "\r\n2 - Hesap Makinesi" +
        "\r\n3 - Ortalama hesaplama " +
        "\r\nSeçiminizi yapınız: "); 

        // karşılama ekranında kullanıcıdan seçim alarak uygulamayı başlatıyorum. Eğer hatalı giriş yaparsa uyarı mesaj ile son bulacak. Doğru girişlerde de fonksiyonları çağırıp program başlıyor.
        
        int secim = Convert.ToInt32(Console.ReadLine());

        switch (secim)
        {
            case 1:
                RastgeleSayiBulmaOyunu();
                break;
            case 2:
                HesapMakinesi();
                break;
            case 3:
                OrtalamaHesaplama();
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız. Uygulamadan çıkılıyor.");
                break;
        }
    }

    static void RastgeleSayiBulmaOyunu()
    {
        // 1 ile 50 arasında rastgele bir sayı belirleyip kullanıcının tahmin etmesini istediğimiz uygulama.

        Random rastgeleSayi = new Random();
        int sayi = rastgeleSayi.Next(1, 51);
        int hak = 5;

        Console.WriteLine("1 ile 50 arasında bir sayı belirlendi. 5 hakkınız var. İlk tahmininizi yapınız.");
        
        /*kullanıcıya 5 hak veriyorum. Her hatalı girişinde hak azalıyor ve eğer 0 olursa kullanıcıya mesaj verip uygulamadan çıkıyoruz. Her hatalı girişinde de daha yüksek ya da daha düşük
         tahmin yapmasını ve kalan hakkını da söylüyoruz.
        */
        
        while (true)
        {
            Console.Write("Tahmininizi girin: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == sayi)
            {
                Console.WriteLine("Doğru tahmin ettiniz. Tebrikler :) ");
                return;
            }
            else if (tahmin < sayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine($"Tahmin hakkınız doldu. Doğru sayı: {sayi}");
                    return;
                }
                Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
            }
            else
            {
                hak--;
                if (hak == 0)
                {
                    Console.WriteLine($"Tahmin hakkınız doldu. Doğru sayı: {sayi}");
                    return;
                }
                Console.WriteLine("Daha düşük bir sayı tahmin edin.");
            }
           
            Console.WriteLine($"Kalan hakkınız: {hak}");
        }

        
    }

    static void HesapMakinesi()
    {
       
        // Önce kullanıcıdan iki sayı girmesini söylüyoruz.
        
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin:" +
            "\r\n Toplama işlemi için + ya basınız" +
            "\r\n Çıkarma işlemi için - ye basınız" +
            "\r\n Çarpma işlemi için * ya basınız" +
            "\r\n Bölme işlemi  için / ye basınız");

        string islem = Console.ReadLine();
        Console.WriteLine();

        double sonuc = 0;

        /*Sayıları aldıktan sonra da hangi işlemleri yapmasını istediğini soruyoruz Geçerli işlem vermezse uygulamadan çıkıyoruz. Doğru seçim yaparsa işlem yapıp ekrana gösteriyoruz.
        Eğer 0 a bölmeye çalışırsa hata verdiriyoruz.
        */


        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                break;
            case "/":
                if (sayi2 == 0)
                {
                    Console.WriteLine("Herhangi bir sayıyı 0'a bölemezsiniz. Uygulamadan çıkılıyor");
                    return;
                }
                sonuc = sayi1 / sayi2;
                break;
            default:
                Console.WriteLine("Geçersiz işlem yaptınız. Uygulamadan çıkılıyor.");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }

    static void OrtalamaHesaplama()
    {
        
        // burada sırasıyla notları alıyorum. Her not girildiğinde de if ile 0 ile 100 arasında girilip girilmediğini kontrol ediyorum. Hatalı not girilirse hata verilecek. Girilmezse program çalışacak.
        
        Console.Write("Birinci ders notunu girin: ");
        double birinciNot = Convert.ToDouble(Console.ReadLine());

        if (birinciNot < 0 || birinciNot > 100)
        {
            Console.WriteLine("Hatalı not girdiniz. Notunuz 1 ile 100 arasında olmalıydı.");
            return;
        }

        Console.Write("İkinci ders notunu girin: ");
        double ikinciNot = Convert.ToDouble(Console.ReadLine());

        if (ikinciNot < 0 || ikinciNot > 100)
        {
            Console.WriteLine("Hatalı not girdiniz. Notunuz 1 ile 100 arasında olmalıydı.");
            return;
        }

        Console.Write("Üçüncü ders notunu girin: ");
        double üçüncüNot = Convert.ToDouble(Console.ReadLine());

        if (üçüncüNot < 0 || üçüncüNot > 100)
        {
            Console.WriteLine("Hatalı not girdiniz. Notunuz 1 ile 100 arasında olmalıydı.");
            return;
        }


        // girilen notların ortalamasını hesaplayıp kullanıcıya söylüyorum.

        double ortalama = (birinciNot + ikinciNot + üçüncüNot) / 3;
        Console.WriteLine($"Ortalamanız: {ortalama}");

        string harfNotu;
        
        // burada bir harf notu oluşturdum. İf ile ortalamayı kontrol edip harf notunu belirliyoruz. Sonra da ekrana bastırıyoruz.


        if (ortalama >= 90) harfNotu = "AA";
        else if (ortalama >= 85) harfNotu = "BA";
        else if (ortalama >= 80) harfNotu = "BB";
        else if (ortalama >= 75) harfNotu = "CB";
        else if (ortalama >= 70) harfNotu = "CC";
        else if (ortalama >= 65) harfNotu = "DC";
        else if (ortalama >= 60) harfNotu = "DD";
        else if (ortalama >= 55) harfNotu = "FD";
        else harfNotu = "FF";

        Console.WriteLine($"Harf Notunuz: {harfNotu}");
    }
}

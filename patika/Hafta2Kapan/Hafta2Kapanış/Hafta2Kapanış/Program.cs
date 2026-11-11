// Soru 1
Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

// Soru 2
string metinselDeger = "C# Programlama";
int tamSayiDeger = 2025;
Console.WriteLine($"Metinsel Değer: {metinselDeger}, Tam Sayı Değer: {tamSayiDeger}");

// Soru 3
Random random = new Random();
int rastgeleSayi = random.Next();
Console.WriteLine($"Rastgele Sayı: {rastgeleSayi}");

// Soru 4
int rastgeleSayi2 = random.Next();
Console.WriteLine($"3'e Bölümünden Kalan: {rastgeleSayi2 % 3}");

// Soru 5
Console.Write("Yaşınızı giriniz: ");
int yas = int.Parse(Console.ReadLine());
Console.WriteLine(yas > 18 ? "+" : "-");

// Soru 6
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}

// Soru 7
Console.Write("İlk ismi giriniz: ");
string isim1 = Console.ReadLine();
Console.Write("İkinci ismi giriniz: ");
string isim2 = Console.ReadLine();
(string tempIsim1, string tempIsim2) = (isim2, isim1);
Console.WriteLine($"Yeni İsimler: {tempIsim1}, {tempIsim2}");

// Soru 8
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
}
BenDegerDondurmem();

// Soru 9
int Toplam(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
Console.WriteLine($"Toplam: {Toplam(5, 7)}");

// Soru 10
string BoolToString(bool deger)
{
    return deger ? "True değeri seçtiniz" : "False değeri seçtiniz";
}
Console.Write("True/False giriniz: ");
bool giris = bool.Parse(Console.ReadLine());
Console.WriteLine(BoolToString(giris));

// Soru 11
int EnYasli(int yas1, int yas2, int yas3)
{
    return Math.Max(yas1, Math.Max(yas2, yas3));
}
Console.WriteLine($"En Yaşlı: {EnYasli(25, 30, 28)}");

// Soru 12
int EnBuyukSayiAl()
{
    int enBuyuk = int.MinValue;
    string giris;
    Console.WriteLine("Sayıları giriniz (Bitirmek için 'b' yazın):");
    while ((giris = Console.ReadLine()) != "b")
    {
        int sayi = int.Parse(giris);
        if (sayi > enBuyuk) enBuyuk = sayi;
    }
    return enBuyuk;
}
Console.WriteLine($"En Büyük Sayı: {EnBuyukSayiAl()}");

// Soru 13
void IsimleriDegistir(ref string ad1, ref string ad2)
{
    (ad1, ad2) = (ad2, ad1);
}
string isimA = "Ali";
string isimB = "Veli";
IsimleriDegistir(ref isimA, ref isimB);
Console.WriteLine($"Yeni İsimler: {isimA}, {isimB}");

// Soru 14
bool TekMi(int sayi)
{
    return sayi % 2 != 0;
}
Console.WriteLine($"Tek mi? {TekMi(5)}");

// Soru 15
double GidilenYol(double hiz, double zaman)
{
    return hiz * zaman;
}
Console.WriteLine($"Gidilen Yol: {GidilenYol(60, 2)} km");

// Soru 16
double DaireAlan(double yaricap)
{
    return Math.PI * yaricap * yaricap;
}
Console.WriteLine($"Dairenin Alanı: {DaireAlan(5)}");

// Soru 17
string cumle = "Zaman bir GeRi SayIm";
Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

// Soru 18
string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);

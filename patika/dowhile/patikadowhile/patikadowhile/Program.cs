using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit değeri girin: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        // While döngüsü ile
        Console.WriteLine("While döngüsü ile çıktı:");
        int sayaç = 0;
        while (sayaç <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayaç++;
        }

        Console.WriteLine(); 

        // Do-While döngüsü ile
        Console.WriteLine("Do-While döngüsü ile çıktı:");
        sayaç = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayaç++;
        } while (sayaç <= limit);
    }
}

/*
do while da döngü mutlaka en az bir kere çalışır çünkü ilk önce işi yapar ardından koşula bakar. 

While da ise ilk önce koşula bakıyor. Yani kullanıcı negatif sayı girse dahi do while da bir kere de olsa çalışacaktır.

*/

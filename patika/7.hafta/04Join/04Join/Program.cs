using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using _04Join;
class Program
{
    static void Main(string[] args)  // Ana metodun adı Main olmalı
    {
        // Yazarlar listesi
        List<Author> Yazarlar = new List<Author>()
        {
            new Author { AuthorId = 1, Name = "Steve Erikson" },
            new Author { AuthorId = 2, Name = "J.R.R. Tolkien" },
            new Author {AuthorId=3, Name= "Dave Gurney"}
        };
        
        //Kitaplar Listesi
       
        List<Books> kitaplar = new List<Books>()
        {
            new Books {AuthorId = 1, BookId = 1, Title="Ölühane Kapıları"},
            new Books {AuthorId=2, BookId=2, Title = "Yüzüklerin Efendisi"},
            new Books {AuthorId=1, BookId=3, Title="Ay Bahçeleri"},
            new Books {AuthorId=2, BookId=4, Title= "Hobbit"},
            new Books {AuthorId=3, BookId =5, Title = "Aklından Bir Sayı Tut"}

        };

        // join ile author id leri birleştiriyoruz

        var Birleştirme = Yazarlar.Join(kitaplar,
            x => x.AuthorId,
            y => y.AuthorId,
            (x, y) => new
            {
                AuthorName = x.Name,
                BookName = y.Title
            }
            );

        // Burdada yazdırıyoruz
        foreach (var author in Birleştirme)
        {
            Console.WriteLine($"Yazar: {author.AuthorName}, Kitap adı: {author.BookName}");
        }
    }
}
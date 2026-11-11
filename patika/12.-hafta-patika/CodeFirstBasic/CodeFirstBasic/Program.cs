
using CodeFirstBasic.Data;

using (var db = new PatikaFirstDbContext())
{
    Console.WriteLine("Game Table : ");

    foreach (Game game in db.Games)
    {
        Console.WriteLine($"{game.Id} {game.Name} {game.Rating} {game.Rating}");


    }
    Console.WriteLine("Film Table: ");

    foreach (Movie movie in db.Movies)
    {
        Console.WriteLine($"{movie.Id} {movie.Genre} {movie.ReleaseYear} {movie.Title}");


    }

}
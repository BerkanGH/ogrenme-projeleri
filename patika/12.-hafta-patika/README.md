Survivor 

Şu an biraz eksik. Sınavlarım başladığı için son haftalarda yetiştiremedim. O yüzden daha fazla vakit kaybetmeden hızlıca yaptım. Eklemeleri yapacağım. Geç kaldığım için kusura bakmayın :/



CodeFirstBasic Ve CodeRelation da npgsql kullandım. Context sınıflarında bu kod ile

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=*****;Database=dbname");
    }
bağlandım.

Modelbuilding kısımlarında örnek birkaç veri yaptım. Herhangi bir crud işlemi istemediğinden database ime ekleyip bıraktım.

Relation kısmında bire çok bağlantısı içinde classlarda property kısmında liste ekledim. 

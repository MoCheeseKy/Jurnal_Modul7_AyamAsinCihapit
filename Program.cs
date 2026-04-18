Console.WriteLine("Deserialization 1:\n");

        FilmFavorit_103022400076 mhs = new FilmFavorit_103022400076();
        mhs.readJSON();

Console.WriteLine("\n__________\nDeserialization 2:\n");
        Watchlist_103022400076 wth  = new Watchlist_103022400076();
        wth.ReadJSON();
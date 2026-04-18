namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###Deserialization 1");
            FilmFavorit_103022400073.ReadJson();
            Console.WriteLine("###Deserialization 2");
            Watchlist_103022400073.ReadJson();
            Console.WriteLine("###Deserialization 3");
            GenreDictionary_103022400073.ReadJson();
            FilmFavorit_103022400003.ReadJSON();
            Watchlist_103022400003.ReadJSON();
            GenreDictionary_103022400003.ReadJSON();    
        }
    }

}
﻿

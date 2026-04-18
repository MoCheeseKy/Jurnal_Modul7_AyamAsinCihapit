using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class Watchlist_103022400073
    {
    //        "watchlistName": "Naufal Watch List",
    //"createdBy": "Kelompok Ayam Asin Cihapit",
    //"movies": [
    //    {
    //        "id": "F101",
    //        "title": "The Matrix",
    //        "year": 1999,
    //        "genre": "Action",
    //        "rating": 8.7
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<FilmFavorit_103022400073> movies { get; set; }

        public static void ReadJson()
        {
            string filepath = "../../../jurnal7_2_103022400073.json";
            string jsonstring = File.ReadAllText(filepath);

            Watchlist_103022400073 watchlist = JsonSerializer.Deserialize<Watchlist_103022400073>(jsonstring);

            Console.WriteLine($"Watchlist Name: {watchlist.watchlistName}");
            Console.WriteLine($"Created By: {watchlist.createdBy}");
            Console.WriteLine("Movies: ");
            int count = 1;
            for(int i = 0; i < watchlist.movies.Count; i++)
            {
                FilmFavorit_103022400073 film = watchlist.movies[i];
                Console.WriteLine($"F10{count} {film.title} ({film.year} - {film.rating})");
            }
        }
    }
}

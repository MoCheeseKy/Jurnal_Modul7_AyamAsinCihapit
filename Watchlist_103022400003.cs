using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class Watchlist_103022400003
    {
            public string watchlistName { get; set; }
            public string createdBy { get; set; }
            public List<Movie> movies { get; set; } 
            
        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_2_103022400003.json");
            Watchlist_103022400003 watchlist = JsonSerializer.Deserialize<Watchlist_103022400003>(json);
            Console.WriteLine(
                $"Watchlist Name: {watchlist.watchlistName}\n" +
                $"Created By: {watchlist.createdBy}");
            Console.WriteLine("Movies:");
            foreach(var movie in watchlist.movies)
            {
                Console.WriteLine($"{movie.id} {movie.title} ({movie.year} - {movie.rating.ToString("0.0")})");
            }
        }
    }

    class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }

    }
}
        
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }

    }
    internal class watchlistData
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movie> movies { get; set; }
    }

    internal class Watchlist_103022430015
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022430015.json");
            watchlistData data = JsonSerializer.Deserialize<watchlistData>(jsonString);

            Console.WriteLine("Watchlist\n");
            Console.WriteLine("Watchlist name: " + data.watchlistName);
            Console.WriteLine(" ");
            Console.WriteLine("created by : " + data.createdBy);
            Console.WriteLine(" ");
            Console.WriteLine("Movies : ");

            for (int i = 0; i < data.movies.Count; i++)
            {
                Console.WriteLine(data.movies[i].id + " " +  data.movies[i].title + " " + data.movies[i].year + " " + data.movies[i].rating);
            }

            Console.WriteLine();


        }
    }
}

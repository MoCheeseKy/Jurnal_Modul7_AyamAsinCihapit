using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


public class Watchlist
    {
        public string id { get; set; }
        public string title { get; set; } 
        public int year { get; set; }    
        public string genre { get; set; }
        public string rating { get; set; }
}

    public class Watchlist_103022400076 
{
    public List<Watchlist> movies { get; set; }

    public string watchlistName { get; set; }

    public string createdBy { get; set; }
    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103022400076.json");
        Watchlist_103022400076 data = JsonSerializer.Deserialize<Watchlist_103022400076>(json);
        Console.WriteLine($"Watchlist Name : {data.watchlistName} \nCreated By : {data.createdBy}\nMovies :");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{data.movies[i].id} {data.movies[i].title} ({data.movies[i].year} - {data.movies[i].genre} - {data.movies[i].rating})");
        }
    }

}

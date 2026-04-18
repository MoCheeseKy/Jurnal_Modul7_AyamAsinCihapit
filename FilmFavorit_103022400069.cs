using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class FilmFavorit_103022400069
    {
        public void ReadJSON()  
        {
            string filePath = "jurnal7_1_103022400069.json";
            string jsonString = File.ReadAllText(filePath);
            Film flm = JsonSerializer.Deserialize<Film>(jsonString);
            Console.WriteLine("Titles "+ flm.title + ", Directors " + flm.director + " , Year " +flm.year+ " , Genre "+ flm.genre+ " , Rating " + flm.rating + "/10 , Duration "+flm.durationMinutes+" Min , Watched ? "+flm.isWatched);
        }
    }
    public class Film
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }


    }
}


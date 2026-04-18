using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class FilmFavorit_103022400073
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public static void ReadJson()
        {
            string filePath = "../../../jurnal7_1_103022400073.json";
            string jsonString = File.ReadAllText(filePath);

            FilmFavorit_103022400073 filmFav = JsonSerializer.Deserialize<FilmFavorit_103022400073>(jsonString);

            Console.WriteLine($"{filmFav.title} | {filmFav.genre} ({filmFav.year} - {filmFav.rating}) {filmFav.durationMinutes} minutes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class FilmFavorit_103022430015
    {
        public string title { get ; set; }
        public string director { get ; set; }
        public string year {  get ; set; }
        public string genre { get ; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public Boolean isWatched { get; set; }

        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022430015.json");
            FilmFavorit_103022430015 data = JsonSerializer.Deserialize<FilmFavorit_103022430015>(json);

            Console.WriteLine($"Title {data.title} yang di direct oleh {data.director} dengan genre {data.genre} " +
                $"dan dirilis pada tahun {data.year}. Saya memberinya {data.rating}/10. Satu-satunya complain yang saya punya tentang film ini adalah " +
                $"runtimenya yang kurang panjang menurut saya, filmnya hanya {data.durationMinutes} menit. " +
                $"Jika menanya apakah saya pernah nonton filmnya, jawabannya adalah {data.isWatched}"); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.Json;

    public class FilmFavorit_103022400076
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void readJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022400076.json");
            FilmFavorit_103022400076 data = JsonSerializer.Deserialize<FilmFavorit_103022400076>(json);

            Console.WriteLine($"Film berJudul {data.title} \nyang disutradarai oleh {data.director} \npada tahun {data.year}, \nbergenre {data.genre}, \nyang ber-rating {data.rating} \nberdurasi {data.durationMinutes}, \nsudah ditonton? {data.isWatched}");
        }
    }


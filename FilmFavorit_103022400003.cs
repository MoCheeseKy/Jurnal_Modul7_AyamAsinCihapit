using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class FilmFavorit_103022400003
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; } = false;    

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022400003.json");
            FilmFavorit_103022400003 film = JsonSerializer.Deserialize<FilmFavorit_103022400003>(json);
            Console.WriteLine(
                $"Title: {film.title}, " +
                $"Director: {film.director}, " +
                $"Year: {film.year}, " +
                $"Genre: {film.genre}, " +
                $"Rating: {film.rating}, " +
                $"DurationMinutes: {film.durationMinutes}, " +
                $"IsWatched: {film.isWatched}");

        }
    }
}

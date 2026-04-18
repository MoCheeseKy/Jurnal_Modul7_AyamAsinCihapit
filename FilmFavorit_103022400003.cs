using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class FilmFavorit_103022400003
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        public int DurationMinutes { get; set; }
        public bool IsWatched { get; set; } = false;    

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022400003.json");
            FilmFavorit_103022400003 film = JsonSerializer.Deserialize<FilmFavorit_103022400003>(json);
            Console.WriteLine(
                $"Title: {film.Title}, " +
                $"Director: {film.Director}, " +
                $"Year: {film.Year}, " +
                $"Genre: {film.Genre}, " +
                $"Rating: {film.Rating}, " +
                $"DurationMinutes: {film.DurationMinutes}, " +
                $"IsWatched: {film.IsWatched}");

        }
    }
}

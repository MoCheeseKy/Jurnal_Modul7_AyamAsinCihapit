using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class GenreDictionary_103022400003
    {
        GenreDictionarys GenreDictionary { get; set; }
        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_3_103022400003.json");
            GenreDictionary_103022400003 genreDictionary = JsonSerializer.Deserialize<GenreDictionary_103022400003>(json);


            Console.WriteLine("Category: " + genreDictionary.GenreDictionary.category);
            if (genreDictionary.GenreDictionary.GenreInfo != null)
            {
                Console.WriteLine("ID: " + genreDictionary.GenreDictionary.GenreInfo.id);
                Console.WriteLine("Name: " + genreDictionary.GenreDictionary.GenreInfo.name);
                Console.WriteLine("Description: " + genreDictionary.GenreDictionary.GenreInfo.description);
                foreach (var movie in genreDictionary.GenreDictionary.GenreInfo.popularMovies)
                {
                    Console.WriteLine("Popular Movies: " + string.Join(", ", movie.popularMovies));
                }
            }
        }
    }

    class GenreDictionarys
    {
            public string category { get; set; }
            GenreInfos GenreInfo { get; set; }

    }

    class GenreInfos
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<PopularMovies> popularMovies { get; set; }
    }

    class PopularMovies
    {
        public List<string> popularMovies { get; set; }
    }
} 


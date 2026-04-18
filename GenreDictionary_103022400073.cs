using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jurnal_Modul7_AyamAsinCihapit
{
    internal class GenreDictionary_103022400073
    {
        public string category { get; set; }

        [JsonPropertyName("GenreInfo")]
        public IGenreInfo GenreInfo { get; set; }

        public static void ReadJson() {
            string filepath = "../../../jurnal7_3_103022400073.json";
            string json = File.ReadAllText(filepath);

            GenreDictionary_103022400073 genreDic = JsonSerializer.Deserialize<GenreDictionary_103022400073>(json);

            IGenreInfo genInfo = new IGenreInfo();
            genInfo = genreDic.GenreInfo;
            Console.WriteLine($"ID: {genInfo.id}");
            Console.WriteLine($"Name: {genInfo.name}");
            Console.WriteLine($"Description: {genInfo.description}");
            Console.Write($"Popular Movies: ");
            for (int i = 0; i < genInfo.popularMovies.Length; i++)
            {
                Console.Write(genInfo.popularMovies[i]);
                if (i != (genInfo.popularMovies.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }
    }
    class IGenreInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string[] popularMovies { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VideoGameTrackerLibrary.Models
{   
    public class GenresModelContainer
    {
        [JsonPropertyName("genres")]
        public List<GenresModel> Genres { get; set; } = new List<GenresModel>();
    }

    public class GenresModel
    {
        [JsonPropertyName("genre_category")]
        public string GenreCategory { get; set; } = string.Empty;

        [JsonPropertyName("genre_category_id")]
        public int GenreCategoryId { get; set; }

        [JsonPropertyName("genre_description")]
        public string GenreDescription { get; set; } = string.Empty;

        [JsonPropertyName("genre_id")]
        public int GenreId { get; set; }

        [JsonPropertyName("genre_name")]
        public string GenreName { get; set; } = string.Empty; 
    }
}

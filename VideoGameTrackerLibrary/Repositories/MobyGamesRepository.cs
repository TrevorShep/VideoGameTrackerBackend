using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VideoGameTrackerLibrary.Models;
using VideoGameTrackerLibrary.Repositories.Interfaces;

namespace VideoGameTrackerLibrary.Repositories
{
    public class MobyGamesRepository : IMobyGamesRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MobyGamesRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        static string baseUrl = "https://api.mobygames.com/v1/";
        static Dictionary<string, string?> queryParams = new Dictionary<string, string?>
        {
            { "api_key",  "moby_MDU9c4VEOLjDGrEvOuJc3043pp7" }
        };

        public async Task<HttpResponseMessage> FetchFromMobyGames(string endpoint)
        {
            HttpClient client = _httpClientFactory.CreateClient();
            string url = QueryHelpers.AddQueryString(baseUrl + endpoint, queryParams);

            HttpResponseMessage response = await client.GetAsync(url);
            return response;
        }

        // Genres methods
        public async Task<GenresModelContainer> GetGenres()
        {
            HttpResponseMessage response = await FetchFromMobyGames("genres");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<GenresModelContainer>(data);
            }
            else
            {
                throw new HttpRequestException($"Failed to fetch data: {response.StatusCode}");
            }
        }

        public async Task<GenresModel> GetGenreById(int id)
        {
            GenresModelContainer genresContainer = await GetGenres();

            GenresModel genre = genresContainer.Genres.FirstOrDefault(x => x.GenreId == id);
            return genre;
        }

        public async Task<string> GetOneGameTest()
        {
            HttpClient client = _httpClientFactory.CreateClient();
            string url = QueryHelpers.AddQueryString(baseUrl + "games?limit=1&format=brief", queryParams);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                throw new HttpRequestException($"Failed to fetch data: {response.StatusCode}");
            }
        }
    }
}

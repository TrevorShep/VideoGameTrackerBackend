using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static Dictionary<string, string> queryParams = new Dictionary<string, string>
        {
            { "api_key",  "moby_MDU9c4VEOLjDGrEvOuJc3043pp7" }
        };

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

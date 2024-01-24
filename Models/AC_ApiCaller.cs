using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaicedoRamos_Progreso3.Controladores
{
    public class ApiCaller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<AC_Artist.Root> GetArtistData(string artistName)
        {
            string url = $"https://api.musixmatch.com/ws/1.1/artist.search?apikey=220c88aac709236296f7d4ff683d403b&q_artist={artistName}&page_size=30";
            string json = await GetJsonFromAPI(url);
            AC_Artist.Root artists = JsonSerializer.Deserialize<AC_Artist.Root>(json);
            return artists;
        }

        private async Task<string> GetJsonFromAPI(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}

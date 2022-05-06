using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JokeHTTPClient
{
    public class JokeClient
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task<JokeContent> GetJokeAsync(string path)
        {
            JokeContent jokeContent = null;
            HttpResponseMessage response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                jokeContent = await response.Content.ReadAsAsync<JokeContent>();
            }
            return jokeContent;
        }

        public static async Task RunAsync(string categoryName)
        {
            try
            {
                JokeContent joke = await GetJokeAsync($"https://v2.jokeapi.dev/joke/{categoryName}");
                JokeContent.ShowJoke(joke);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

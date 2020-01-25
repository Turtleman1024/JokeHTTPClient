using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace JokeHTTPClient
{
    public class JokeContent
    {
        public string Category { get; set; } = null;
        public string Type { get; set; } = null;
        public string Joke { get; set; } = null;
        public string Setup { get; set; } = null;
        public string Delivery { get; set; } = null;
        //public string Nsfw { get; set; } = null;
        //public string Religious { get; set; } = null;
        //public string Political { get; set; } = null;
        public string Id { get; set; } = null;
    }
    
    public class JokeHTTPClient
    {
        private static readonly HttpClient client = new HttpClient();

        static void ShowJoke(JokeContent joke)
        {
            if (joke.Type.ToLower() == "twopart")
            {
                Console.WriteLine(
                        $"Id: {joke.Id}\n" +
                        $"Category: {joke.Category}\n" +
                        $"Type: {joke.Type}\n" +
                        $"Setup: {joke.Setup}" +
                        $"Delivery: {joke.Delivery}\n");
            }
            else
            {
                Console.WriteLine(
                        $"Id: {joke.Id}\n" +
                        $"Category: {joke.Category}\n" +
                        $"Type: {joke.Type}\n" +
                        $"Joke: {joke.Joke}\n");
            }
        }

        static async Task<JokeContent> GetJokeAsync(string path)
        {
            JokeContent jokeContent = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if(response.IsSuccessStatusCode)
            {
                jokeContent = await response.Content.ReadAsAsync<JokeContent>();
            }
            return jokeContent;
        }

        static async Task RunAsync(string categoryName)
        {
            try
            {
                //for (int i = 0; i <= 9; i++)
                //{
                    JokeContent joke = await GetJokeAsync($"https://sv443.net/jokeapi/category/{categoryName}?blacklistFlags=religious,political,nsfw");
                    ShowJoke(joke);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            RunAsync("Programming").GetAwaiter().GetResult();
            Console.ReadLine();
        }
    }
}

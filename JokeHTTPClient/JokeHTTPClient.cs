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
        public string Nsfw { get; set; } = null;
        public string Religious { get; set; } = null;
        public string Political { get; set; } = null;
        public string Id { get; set; } = null;
    }
    
    public class JokeHTTPClient
    {
        private static readonly HttpClient _client = new HttpClient();

        private static void ShowJoke(JokeContent joke)
        {
            if (joke.Type.ToLower() == "twopart")
            {
                Console.WriteLine(
                        $"Id: {joke.Id}\n" +
                        $"Category: {joke.Category}\n" +
                        $"Type: {joke.Type}\n" +
                        $"Setup: {joke.Setup}\n" +
                        $"Delivery: {joke.Delivery}\n" +
                        $"NSFW: {joke.Nsfw}\n" +
                        $"Religious: {joke.Religious}\n" +
                        $"Political: {joke.Political}\n");
            }
            else
            {
                Console.WriteLine(
                        $"Id: {joke.Id}\n" +
                        $"Category: {joke.Category}\n" +
                        $"Type: {joke.Type}\n" +
                        $"Joke: {joke.Joke}\n" +
                        $"NSFW: {joke.Nsfw}\n" +
                        $"Religious: {joke.Religious}\n" +
                        $"Political: {joke.Political}\n");
            }
        }

        private static async Task<JokeContent> GetJokeAsync(string path)
        {
            JokeContent jokeContent = null;
            HttpResponseMessage response = await _client.GetAsync(path);
            if(response.IsSuccessStatusCode)
            {
                jokeContent = await response.Content.ReadAsAsync<JokeContent>();
            }
            return jokeContent;
        }

        private static async Task RunAsync(string categoryName)
        {
            try
            {
                JokeContent joke = await GetJokeAsync($"https://sv443.net/jokeapi/category/{categoryName}");
                ShowJoke(joke);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void EnterMessage()
        {
            Console.WriteLine("\tWelcome to Joke HTTP Client");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("This program calls the Joke API by sv433");
            Console.WriteLine("You can get Jokes in three categories");
            Console.WriteLine("1. Programming\n2. Miscellaneous\n3. Dark\n4. Any\n");
            Console.WriteLine("To exit the application enter Exit");
        }

        private static string Prompt()
        {
            Console.Write("Enter a category number or name: ");
            var userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                case "Programming":
                    userInput = "Programming";
                    break;
                case "2":
                case "Miscellaneous":
                    userInput = "Miscellaneous";
                    break;
                case "3":
                case "Dark":
                    userInput = "Dark";
                    break;
                case "4":
                case "Any":
                    userInput = "Any";
                    break;
                default:
                    userInput = "Quit";
                    break;
            };


            return userInput;
        }

        private static void ExitMessage()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Thank for checking out the application.");
        }

        static void Main(string[] args)
        {
            bool exit = false;
            string userInput = null;
            EnterMessage();

            while (!exit)
            {
                userInput = Prompt();
                if (userInput != "Quit")
                {
                    RunAsync(userInput).GetAwaiter().GetResult();
                }
                else
                {
                    exit = true;
                }
            }

            ExitMessage();
            Console.ReadLine();
        }
    }
}

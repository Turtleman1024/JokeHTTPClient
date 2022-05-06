using System;
using System.Threading;

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

        public static void ShowJoke(JokeContent joke)
        {
            if (joke.Type.ToLower() == "twopart")
            {
                //Console.WriteLine(
                //        $"\nId: {joke.Id}\n" +
                //        $"Category: {joke.Category}\n" +
                //        $"Type: {joke.Type}\n" +
                //        $"Setup: {joke.Setup}\n" +
                //        $"Delivery: {joke.Delivery}\n" +
                //        $"NSFW: {joke.Nsfw}\n" +
                //        $"Religious: {joke.Religious}\n" +
                //        $"Political: {joke.Political}\n");
                Console.WriteLine($"{joke.Setup}\n");
                Thread.Sleep(2000);
                Console.WriteLine( $"{joke.Delivery}\n");
            }
            else
            {
                //Console.WriteLine(
                //        $"\nId: {joke.Id}\n" +
                //        $"Category: {joke.Category}\n" +
                //        $"Type: {joke.Type}\n" +
                //        $"Joke: {joke.Joke}\n" +
                //        $"NSFW: {joke.Nsfw}\n" +
                //        $"Religious: {joke.Religious}\n" +
                //        $"Political: {joke.Political}\n");
                Console.WriteLine(joke.Joke);
            }
        }
    }
}

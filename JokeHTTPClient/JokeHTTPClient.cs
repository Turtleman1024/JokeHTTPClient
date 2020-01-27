using System;

namespace JokeHTTPClient
{
    public class JokeHTTPClient
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string userInput = null;
            Prompts.EnterMessage();

            while (!exit)
            {
                userInput = Prompts.PromptUser();
                if (userInput == "Help")
                {
                    Prompts.HelpMessage();
                }
                else if (userInput == "Exit")
                {
                    exit = true;
                }
                else if (userInput == "Error")
                {
                    Console.WriteLine("\nInvalid Input\n");
                    Prompts.HelpMessage();
                }
                else
                {
                    JokeClient.RunAsync(userInput).GetAwaiter().GetResult();
                }
            }

            Prompts.ExitMessage();
            Console.ReadLine();
        }
    }
}

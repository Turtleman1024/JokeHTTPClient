using System;

namespace JokeHTTPClient
{
    public class JokeHTTPClient
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string userInput = null;
            Messages.EnterMessage();

            while (!exit)
            {
                userInput = Prompts.PromptUser();
                if (userInput == "Help")
                {
                    Messages.HelpMessage();
                }
                else if (userInput == "Exit")
                {
                    exit = true;
                }
                else if (userInput == "Error")
                {
                    Console.WriteLine("\nInvalid Input\n");
                    Messages.HelpMessage();
                }
                else
                {
                    JokeClient.RunAsync(userInput).GetAwaiter().GetResult();
                }
            }

            Messages.ExitMessage();
            Console.ReadLine();
        }
    }
}

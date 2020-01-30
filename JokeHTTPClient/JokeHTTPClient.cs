using System;

namespace JokeHTTPClient
{
    public class JokeHTTPClient
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Logger logger = new Logger();
            Messages message = new Messages(logger);

            message.EnterMessage();

            while (!exit)
            {
                string userInput = Prompts.PromptUser();
                if (userInput == "Help")
                {
                    message.HelpMessage();
                }
                else if (userInput == "Exit")
                {
                    exit = true;
                }
                else if (userInput == "Error")
                {
                    logger.Log("\nInvalid Input\n");
                    message.HelpMessage();
                }
                else
                {
                    JokeClient.RunAsync(userInput).GetAwaiter().GetResult();
                }
            }

            message.ExitMessage();
            Console.ReadLine();
        }
    }
}

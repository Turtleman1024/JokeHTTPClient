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

                switch (userInput.ToLower())
                {
                    case "help":
                        {
                            message.HelpMessage();
                            break;
                        }
                    case "exit":
                        {
                            exit = true;
                            break;
                        }
                    case "error":
                        {
                            logger.Log("\nInvalid Input\n");
                            message.HelpMessage();
                            break;
                        }
                    default:
                        {
                            JokeClient.RunAsync(userInput).GetAwaiter().GetResult();
                            break;
                        }
                }
            }

            message.ExitMessage();
            Console.ReadLine();
        }
    }
}

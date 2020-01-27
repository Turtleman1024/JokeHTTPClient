using System;

namespace JokeHTTPClient
{
    public class Prompts
    {

        public static void EnterMessage()
        {
            Console.WriteLine("\tWelcome to Joke HTTP Client");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("This program calls the Joke API by sv433");
            HelpMessage();
        }

        public static void HelpMessage()
        {
            Console.WriteLine("You can get Jokes in four categories");
            Console.WriteLine("1. Programming\n2. Miscellaneous\n3. Dark\n4. Any\n");
            Console.WriteLine("If you need help at anytime enter 5 or Help\n");
            Console.WriteLine("To exit the application enter 6 or Exit\n");
        }

        public static string PromptUser()
        {
            Console.Write("Enter a category number or name: ");
            var userInput = Console.ReadLine();
            switch (userInput)
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
                case "5":
                case "Help":
                    userInput = "Help";
                    break;
                case "6":
                case "Exit":
                    userInput = "Exit";
                    break;
                default:
                    userInput = "Error";
                    break;
            };
            return userInput;
        }

        public static void ExitMessage()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Thank for checking out the application.");
        }
    }
}

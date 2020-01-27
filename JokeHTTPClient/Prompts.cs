using System;

namespace JokeHTTPClient
{
    public class Prompts
    {
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
    }
}

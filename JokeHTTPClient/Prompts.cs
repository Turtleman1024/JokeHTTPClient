using System;

namespace JokeHTTPClient
{
    public class Prompts
    {
        public static string PromptUser()
        {
            Console.Write("Enter a category number or name: ");
            var userInput = Console.ReadLine();
            userInput = userInput switch
            {
                "1" or "Programming" => "Programming",
                "2" or "Miscellaneous" => "Miscellaneous",
                "3" or "Dark" => "Dark",
                "4" or "Any" => "Any",
                "5" or "Help" => "Help",
                "6" or "Exit" => "Exit",
                _ => "Error",
            };
            return userInput;
        }
    }
}

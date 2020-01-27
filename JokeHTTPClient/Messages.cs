using System;
using System.Collections.Generic;
using System.Text;

namespace JokeHTTPClient
{
    public class Messages
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

        public static void ExitMessage()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Thank for checking out the application.");
        }
    }
}

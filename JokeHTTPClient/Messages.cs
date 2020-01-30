using System;
using System.Collections.Generic;
using System.Text;

namespace JokeHTTPClient
{
    public class Messages
    {
        private ILogger _logger;

        public Messages(ILogger logger)
        {
            _logger = logger;
        }

        public void EnterMessage()
        {
            _logger.Log("\tWelcome to Joke HTTP Client");
            _logger.Log("-------------------------------------------");
            _logger.Log("This program calls the Joke API by sv433");
            HelpMessage();
        }

        public void HelpMessage()
        {
            _logger.Log("You can get Jokes in four categories");
            _logger.Log("1. Programming\n2. Miscellaneous\n3. Dark\n4. Any\n");
            _logger.Log("If you need help at anytime enter 5 or Help\n");
            _logger.Log("To exit the application enter 6 or Exit\n");
        }

        public void ExitMessage()
        {
            _logger.Log("-------------------------------------------");
            _logger.Log("Thank for checking out the application.");
        }
    }
}

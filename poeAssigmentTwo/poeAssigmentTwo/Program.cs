using System;
using System.Threading.Tasks;
using poeAssigmentTwo.Services;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize services with renamed classes
            var display = new displayASCII();
            var audio = new audioService();
            var tipsService = new tipsB();
            var chat = new ChatService(display, tipsService);
            var validator = new validateService();

            try
            {
                await audio.PlayGreetingAsync();
                display.ShowASCIIArt();

                string userName = chat.GetUserName();
                display.TypeWrite($"Welcome, {userName}!", 15);

                // Main interaction loop
                bool exitRequested = false;
                while (!exitRequested)
                {
                    chat.ShowMainMenuWithExit(); // Updated menu with exit option

                    Console.Write("\nYour choice: ");
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        display.TypeWrite("Please enter a valid choice.", 10);
                        continue;
                    }

                    var sanitizedInput = input.Trim().ToLower();

                    // Check for exit command
                    if (sanitizedInput == "6" || sanitizedInput == "exit")
                    {
                        exitRequested = true;
                        continue;
                    }

                    // Process other choices
                    chat.ProcessUserChoice(input);
                }
            }
            finally
            {
                audio.Dispose();
                display.TypeWrite("\nThank you for using the Cybersecurity Bot. Stay safe online!", 15);
            }
        }
    }
}
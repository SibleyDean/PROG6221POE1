using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo.Services
{
    public class ChatService
    {
        private readonly displayASCII _display;
        private readonly tipsB _tipsB;
        private readonly List<responseB> _responseB;

        public ChatService(displayASCII display, tipsB tipsService)
        {
            _display = display;
            _tipsB = tipsService;
            _responseB = _tipsB?.GetCybersecurityTips() ?? new List<responseB>();

            // Debug check
            if (_responseB.Count == 0)
            {
                Console.WriteLine("Warning: No cybersecurity tips loaded!");
            }
        }

        public string GetUserName()
        {
            while (true)
            {
                _display.TypeWrite("Please enter your name: ", 15);
                string? name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && name.Length <= 30)
                    return name.Trim();

                _display.TypeWrite("Invalid input. Names must be 1-30 characters.", 10);
            }
        }

        public void ShowMainMenu()
        {
            if (_responseB == null || !_responseB.Any())
            {
                _display.TypeWrite("No topics available at the moment.", 10);
                return;
            }

            _display.TypeWrite("\nWhat cybersecurity topic would you like to learn about?", 15);
            _display.TypeWrite("Choose one of the following options:", 15);

            // Fixed foreach loop - using correct variable names
            foreach (var (response, index) in _responseB.Select((r, i) => (r, i)))
            {
                _display.TypeWrite($"{index + 1}. {response.Title}", 10);
            }

            _display.TypeWrite("\nYou can type the number or the topic name (e.g., '1' or 'passwords')", 10);
        }

        public void ProcessUserChoice(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                _display.TypeWrite("Please enter a valid choice.", 10);
                return;
            }

            var sanitizedInput = input.Trim().ToLower();

            // First check for numeric input
            if (int.TryParse(sanitizedInput, out int choice) &&
                choice > 0 &&
                choice <= _responseB.Count)
            {
                _display.ShowTopic(_responseB[choice - 1]);
                return;
            }

            // Then check for text matches
            var response = _responseB.FirstOrDefault(r =>
                r.Triggers?.Contains(sanitizedInput) == true ||
                r.Title?.ToLower().Contains(sanitizedInput) == true);

            if (response != null)
            {
                _display.ShowTopic(response);
            }
            else
            {
                _display.TypeWrite("I didn't understand that. Please try again.", 10);
                ShowMainMenu(); // Show menu again after invalid input
            }
        }
        public void ShowMainMenuWithExit()
        {
            _display.TypeWrite("\nWhat cybersecurity topic would you like to learn about?", 15);
            _display.TypeWrite("Choose one of the following options:", 15);

            // Display all topics (1-5)
            foreach (var (response, index) in _responseB.Select((r, i) => (r, i)))
            {
                _display.TypeWrite($"{index + 1}. {response.Title}", 10);
            }

            // Add exit option (6)
            _display.TypeWrite("6. Exit the application", 10);
            _display.TypeWrite("\nYou can type the number, topic name (e.g., '1' or 'passwords'), or 'exit'", 10);
        }
    }
}

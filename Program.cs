using System;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot - South Africa";
            Console.WindowWidth = 90;
            Console.WindowHeight = 35;

            try
            {
                // Display startup message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Starting Cybersecurity Awareness Chatbot...");
                Console.ResetColor();
                await Task.Delay(1000);

                // Initialize and start the chatbot
                Chatbot chatbot = new Chatbot();
                await chatbot.StartAsync();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"An error occurred: {ex.Message}");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;
        private bool isRunning;
        private readonly Dictionary<string, string> responses;
        private readonly AudioPlayer audioPlayer;

        public Chatbot()
        {
            responses = InitializeResponses();
            audioPlayer = new AudioPlayer();
            isRunning = true;
        }

        private Dictionary<string, string> InitializeResponses()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["How are you"] = "I'm functioning well,thank you! \n I'm here to help you stay safe online.",
                ["What is your purpose"] = "My purpose is to educate South African citizens about cybersecurity threats and how to protect themselves online.",
                ["What can i ask you about"] = "You can ask me about:\n• Password safety\n• Phishing scams\n• Safe browsing habits\n• Recognizing suspicious links\n• General cybersecurity tips",
                ["Password"] = "PASSWORD SAFETY TIPS:\n• Use at least 12 characters with a mix of uppercase, lowercase, numbers, and symbols\n• Never reuse passwords across different accounts\n• Consider using a password manager like Bitwarden or LastPass\n• Enable two factor authentication whenever available\n• Avoid using personal information like birthdays or names",
                ["Phishing"] = "PHISHING AWARENESS:\n• Never click suspicious links in emails or messages\n• Always verify the sender's email address carefully\n• Be wary of urgent requests for personal information\n• Banks and legitimate companies never ask for passwords via email\n• Check for spelling errors and unusual domain names",
                ["Safe browsing"] = "SAFE BROWSING TIPS:\n• Look for 'https://' in website addresses (the 's' stands for secure)\n• Don't download files from untrusted sources\n• Keep your browser and software updated\n• Use reputable antivirus software\n• Be cautious on public Wi-Fi networks",
                ["Suspicious links"] = "HOW TO SPOT SUSPICIOUS LINKS:\n• Hover over links to see the real URL before clicking\n• Check for misspellings in domain names (e.g., faceb00k.com)\n• Be cautious of shortened URLs (like bit.ly or tinyurl)\n• When in doubt, type the address manually into your browser\n• Look for unusual characters or numbers in the domain",
                ["Help"] = "I can help you learn about cybersecurity \n Try asking me about:\n• Passwords\n• Phishing\n• Safe browsing\n• Suspicious links\n• South Africa cybersecurity",
                ["Goodbye"] = "Stay safe online and remember to think before you click!",
                ["Thanks"] = "You're welcome,stay cyber safe!",
                ["South Africa"] = "SOUTH AFRICA CYBERSECURITY:\n• Report cybercrime to SAPS or the Cybersecurity Hub\n• South Africa has seen a 300% increase in cyberattacks recently\n• Be especially cautious of banking scams (vishing and smishing)\n• The POPI Act protects your personal information"
            };
        }

        public async Task StartAsync()
        {
            //Play voice greeting
            await audioPlayer.PlayVoiceGreetingAsync();

            //Display ASCII art and welcome message
            UIHelper.DisplayAsciiArt();
            UIHelper.DisplayWelcomeMessage();

            //Get user name
            await GetUserNameAsync();

            //Show available topics
            UIHelper.PrintWithTypingEffect("You can ask me about passwords, phishing, safe browsing, or suspicious links.");
            UIHelper.PrintWithTypingEffect("Type 'help' for options or 'goodbye' to exit.\n");

            //Main conversation loop
            await RunConversationLoop();
        }

        private async Task GetUserNameAsync()
        {
            UIHelper.PrintWithTypingEffect("\n Please enter your name:");
            userName = Console.ReadLine()?.Trim();

            while (string.IsNullOrWhiteSpace(userName))
            {
                UIHelper.ShowError("Name cannot be empty. Please enter your name:");
                userName = Console.ReadLine()?.Trim();
            }

            UIHelper.ShowSuccess($"\n Welcome, {userName}!");
            UIHelper.PrintWithTypingEffect("I'm your Cybersecurity Awareness Assistant,how can I help you today?");
            Thread.Sleep(500);
        }

        private async Task RunConversationLoop()
        {
            while (isRunning)
            {
                //Display separator
                UIHelper.PrintColored("\n" + new string('━', 50), ConsoleColor.Cyan);
                UIHelper.PrintColored($"\n{userName}: ", ConsoleColor.Green);

                string userInput = Console.ReadLine()?.Trim() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    UIHelper.ShowError("I didn't receive any input. Please type something.");
                    continue;
                }

                string response = GenerateResponse(userInput);

                UIHelper.PrintColored("Chatbot: ", ConsoleColor.Yellow);
                UIHelper.PrintWithTypingEffect(response);

                if (userInput.Equals("goodbye", StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    isRunning = false;
                }
            }

            UIHelper.PrintWithTypingEffect("\n Thanks for learning about cybersecurity!\n Stay safe online!");
            Thread.Sleep(1500);
        }

        private string GenerateResponse(string input)
        {
            input = input.ToLower().Trim();

            //Check each response keyword
            foreach (var kvp in responses)
            {
                if (input.Contains(kvp.Key))
                {
                    return kvp.Value;
                }
            }

            //Greeting responses
            if (input.Contains("hi") || input.Contains("hello") || input.Contains("hey"))
            {
                return $"Hello {userName}! How can I assist with your cybersecurity questions today?";
            }

            //Exit responses
            if (input.Contains("bye") || input.Contains("exit") || input.Contains("quit"))
            {
                return responses["goodbye"];
            }

            //Thank you responses
            if (input.Contains("thank"))
            {
                return responses["thanks"];
            }

            //Default response for unrecognized input
            return "I didn't quite understand that. Could you rephrase? Try asking about passwords, phishing, safe browsing, or suspicious links. Type 'help' for more options.";
        }
    }
}

//Reference-Pro C# 10 with .NET 6 Textbook
//Reference-w3schools
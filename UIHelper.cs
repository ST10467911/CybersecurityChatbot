using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class UIHelper
    {
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════╗
║                                                              ║
║     ██████╗██╗   ██╗██████╗ ███████╗██████╗                  ║
║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                 ║
║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                 ║ 
║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                 ║
║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                 ║
║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                 ║
║                                                              ║
                  AWARENESS CHATBOT                        
║                   South Africa                               ║
╚══════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Thread.Sleep(500);
        }

        public static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n  ┌──────────────────────────────────────────────────┐");
            Console.WriteLine("  │      Welcome to the Cybersecurity Awareness      │");
            Console.WriteLine("  │              Assistant for South Africa          │");
            Console.WriteLine("  ├──────────────────────────────────────────────────┤");
            Console.WriteLine("  │  I'm here to help you stay safe from:            │");
            Console.WriteLine("  │  1.Phishing Scams      2.Identity Theft          │");
            Console.WriteLine("  │  3.Malware Attacks     4.Social Engineering      │");
            Console.WriteLine("  │  5.Password Vulnerabilities                      │");
            Console.WriteLine("  └──────────────────────────────────────────────────┘");
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        public static void PrintColored(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void PrintWithTypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public static void PrintWithDelay(string message)
        {
            Console.Write(message);
            Thread.Sleep(500);
        }

        public static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {message}");
            Console.ResetColor();
            Thread.Sleep(500);
        }

        public static void ShowSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
    }
}
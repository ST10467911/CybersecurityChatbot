using System;
using System.Media;
using System.IO;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class AudioPlayer
    {
        public async Task PlayVoiceGreetingAsync()
        {
            try
            {
                // Try to play WAV file
                bool wavPlayed = await TryPlayWavFile();

                if (!wavPlayed)
                {
                    // Fallback: beep pattern
                    Console.Beep(440, 500);
                    await Task.Delay(100);
                    Console.Beep(587, 500);
                }

                // Display greeting text with typing effect
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Voice Greeting: ");
                Console.ResetColor();

                string greeting = "'Welcome to the South African Cybersecurity Awareness Chatbot,let's stay safe online together!'";
                foreach (char c in greeting)
                {
                    Console.Write(c);
                    await Task.Delay(25);
                }
                Console.WriteLine();
                await Task.Delay(500);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Audio note: {ex.Message}");
                Console.ResetColor();
            }
        }

        private async Task<bool> TryPlayWavFile()
        {
            string[] possiblePaths = {
                "greeting.wav",
                "Resources/greeting.wav",
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav")
            };

            foreach (string path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    try
                    {
                        using (SoundPlayer player = new SoundPlayer(path))
                        {
                            player.Load();
                            player.Play();
                            await Task.Delay(2500);
                            return true;
                        }
                    }
                    catch
                    {
                        // Continue to next path
                    }
                }
            }
            return false;
        }
    }
}
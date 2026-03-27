Cybersecurity Awareness Chatbot - South Africa

[.NET Build and Test]https://github.com/ST10467911/CybersecurityChatbot

//Project Files
Program.cs, Chatbot.cs, UIHelper.cs, AudioPlayer.cs

greeting.wav, ascii-art.txt, ci-success.png

.github/workflows/dotnet.yml

//CI/CD Pipeline Status

CI Workflow Success (ci-success.png)

//Project Overview

A command-line chatbot educating South African citizens about cybersecurity threats.

//Features

| Feature              | Description 
|----------------------|-------------
| Voice Greeting       | WAV file greeting with beep fallback 
| ASCII Art            | CYBER logo display 
| Personalized         | Asks for and uses user's name 
| Cybersecurity Topics | Passwords, phishing, safe browsing, suspicious links 
| Input Validation     | Handles empty/invalid inputs 
| Enhanced UI          | Colors, borders, typing effect 
| CI/CD                | GitHub Actions automated builds 

//Testing the Application
Test these inputs to verify all functionality:

Input Tested	Expected Response	Status
(empty input)	Error: "I didn't receive any input"	✅
hello	Personalized greeting with user's name	✅
how are you	Status response: "I'm functioning well..."	✅
what is your purpose	Purpose explanation	✅
what can i ask you about	List of available topics	✅
what is phishing	5 phishing awareness tips	✅
tell me about passwords	5 password safety tips	✅
safe browsing	5 safe browsing tips	✅
suspicious links	5 link recognition tips	✅
south africa	SA-specific cybersecurity info	✅
help	Available topics list	✅
thanks	Thank you response	✅
goodbye	Exit message and program ends	✅
asdfgh (nonsense)	Default: "I didn't quite understand..."	✅

//Installation

```bash
git clone https://github.com/ST10467911/CybersecurityChatbot
cd CybersecurityChatbot
dotnet build
dotnet run

//Usage examples 
Please enter your name: Thabo
Welcome, Thabo!

Thabo: What is phishing?
Chatbot: PHISHING AWARENESS: [tips...]

//Rubric Requirements
✅ Voice greeting + ASCII art
✅ Personalized interaction
✅ 4+ cybersecurity topics
✅ Input validation
✅ Enhanced console UI (colors, borders, typing effect)
✅ 4 separate classes
✅ 6+ commits with CI/CD

//Youtube link 
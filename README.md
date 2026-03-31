Cybersecurity Awareness Chatbot - South Africa
[.NET Build and Test]https://github.com/ST10467911/CybersecurityChatbot

//USER MANUAL 
PART 1: DOWNLOADING AND SETTING UP

Step 1: Get the Program

Download from GitHub (Recommended)
1. Open your web browser (Chrome, Edge, Firefox)
2. Go to: `https://github.com/ST10467911/CybersecurityChatbot`
3. Click the green "Code" button
4. Click "Download ZIP"
5. Save the file to your computer (e.g., Desktop or Downloads folder)
6. Right-click the ZIP file and select "Extract All"
7. Choose a location and click "Extract"

Step 2: Install Required Software
Check if you have .NET installed:

1. Press Windows key + R
2. Type `cmd` and press Enter
3. Type `dotnet --version` and press Enter

If you see a version number (like 6.0.0 or higher):
- You're good to go

If you see an error message:
1. Go to: `https://dotnet.microsoft.com/download`
2. Click ".NET 6.0"
3. Click "Download" under "Run desktop apps"
4. Run the installer and follow the steps
5. Restart your computer

Step 3: Open the Program

Using Visual Studio (if installed):

1. Open Visual Studio 2022
2. Click "Open a project or solution"
3. Navigate to the extracted folder
4. Double-click `CybersecurityChatbot.csproj`
5. Press F5 to run

Using Command Line (if no Visual Studio):

1. Press Windows key + R
2. Type `cmd` and press Enter
3. Type: `cd "C:\Users\YourName\Desktop\CybersecurityChatbot"` (change to your folder location)
4. Type: `dotnet run`
5. Press Enter

PART 2: USING THE CHATBOT

Step 4: Start the Program

When the program opens, you'll see:
Starting Cybersecurity Awareness Chatbot...
Voice Greeting: 'Welcome to the South African Cybersecurity Awareness Chatbot...'
Please enter your name: 

Step 5: Enter Your Name

1. Type your name (example: `Thabo`)
2. Press Enter
Welcome, Thabo!
I'm your Cybersecurity Awareness Assistant. How can I help you today?
You can ask me about passwords, phishing, safe browsing, or suspicious links.
Type 'help' for options or 'goodbye' to exit.

Step 6: Ask Cybersecurity Questions

Type your question and press Enter

Here are examples of what to ask:

| Type This | What You'll Learn |
|-----------|-------------------|
| `what is phishing` | How to spot fake emails and scams |
| `tell me about passwords` | How to create strong passwords |
| `safe browsing` | How to stay safe on the internet |
| `suspicious links` | How to spot dangerous links |
| `south africa` | Cyber threats specific to South Africa |
| `help` | List of all topics you can ask about |
| `how are you` | Chatbot responds |
| `what is your purpose` | Explains what it does |

Step 7: Read the Response

The chatbot will respond with colored text:

Green text = Your question
Yellow text = Chatbot's answer
Red text = Error messages
Cyan lines = Separators between messages

Example response:
Chatbot: PHISHING AWARENESS:
• Never click suspicious links in emails or messages
• Always verify the sender's email address carefully
• Be wary of urgent requests for personal information
• Banks and legitimate companies never ask for passwords via email
• Check for spelling errors and unusual domain names

Step 8: Continue the Conversation
1. Type another question
2. Press Enter
3. The chatbot will respond
4. Repeat as many times as you want

Step 9: Exit the Program

Type one of these words and press Enter:
- `goodbye`
- `exit`
- `quit`

You'll see:
Chatbot: Stay safe online! Remember: Think before you click! 

Thanks for learning about cybersecurity! Stay safe online.

The program will close automatically.

QUICK REFERENCE CARD
What to Ask:

| Topic | Try Saying |
|-------|-----------|
| Email scams | "phishing" |
| Strong passwords | "password" |
| Internet safety | "safe browsing" |
| Dangerous links | "suspicious links" |
| All topics | "help" |
| Exit | "goodbye" |

What You'll See:

| Color | Meaning |
|-------|---------|
| Green | Your question |
| Yellow | Chatbot's answer |
| Red | Error message |
| Cyan | Separator lines |


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
https://youtu.be/T4IOU0qhU70

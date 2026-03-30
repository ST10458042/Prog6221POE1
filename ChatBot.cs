using Figgle;
using Figgle.Fonts;
using System;

namespace CyberSecurityChatbot
{
    class Chatbot
    {
        public static void StartChat(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Small.Render("Chat Started!"));
            Console.ResetColor();

            Console.WriteLine("Hello " + userName + "! Ask me anything about cybersecurity.");
            Console.WriteLine("Type 'exit' to quit.");
            Console.WriteLine();

            Response[] responses = new Response[30];

            responses[0] = new Response();
            responses[0].keyword = "phishing";
            responses[0].message = "Phishing is when attackers trick you into giving personal information.";

            responses[1] = new Response();
            responses[1].keyword = "password";
            responses[1].message = "Use strong passwords with numbers, symbols, and uppercase letters.";

            responses[2] = new Response();
            responses[2].keyword = "safe";
            responses[2].message = "Always check HTTPS and avoid suspicious links.";

            responses[3] = new Response();
            responses[3].keyword = "malware";
            responses[3].message = "Malware is harmful software like viruses.";

            responses[4] = new Response();
            responses[4].keyword = "scam";
            responses[4].message = "Scams try to trick you into giving money or personal information.";

            responses[5] = new Response();
            responses[5].keyword = "privacy";
            responses[5].message = "Protect your privacy by not sharing personal information online.";

            responses[6] = new Response();
            responses[6].keyword = "virus";
            responses[6].message = "A virus is a type of malware that spreads and damages systems.";

            responses[7] = new Response();
            responses[7].keyword = "ransomware";
            responses[7].message = "Ransomware locks your files and demands payment to unlock them.";

            responses[8] = new Response();
            responses[8].keyword = "spyware";
            responses[8].message = "Spyware secretly monitors your activities.";

            responses[9] = new Response();
            responses[9].keyword = "firewall";
            responses[9].message = "A firewall protects your network by blocking unauthorized access.";

            responses[10] = new Response();
            responses[10].keyword = "antivirus";
            responses[10].message = "Antivirus software detects and removes malicious programs.";

            responses[11] = new Response();
            responses[11].keyword = "update";
            responses[11].message = "Always update your software to fix security vulnerabilities.";

            responses[12] = new Response();
            responses[12].keyword = "backup";
            responses[12].message = "Regular backups protect your data from loss.";

            responses[13] = new Response();
            responses[13].keyword = "wifi";
            responses[13].message = "Avoid using public Wi-Fi for sensitive transactions.";

            responses[14] = new Response();
            responses[14].keyword = "email";
            responses[14].message = "Do not open suspicious email attachments.";

            responses[15] = new Response();
            responses[15].keyword = "link";
            responses[15].message = "Avoid clicking unknown or suspicious links.";

            responses[16] = new Response();
            responses[16].keyword = "https";
            responses[16].message = "HTTPS ensures secure communication over the internet.";

            responses[17] = new Response();
            responses[17].keyword = "identity";
            responses[17].message = "Identity theft happens when someone steals your personal information.";

            responses[18] = new Response();
            responses[18].keyword = "fraud";
            responses[18].message = "Fraud involves deceiving people for financial gain.";

            responses[19] = new Response();
            responses[19].keyword = "social engineering";
            responses[19].message = "Social engineering tricks people into revealing confidential information.";

            responses[20] = new Response();
            responses[20].keyword = "2fa";
            responses[20].message = "Two-factor authentication adds extra security to your accounts.";

            responses[21] = new Response();
            responses[21].keyword = "authentication";
            responses[21].message = "Authentication verifies your identity before granting access.";

            responses[22] = new Response();
            responses[22].keyword = "encryption";
            responses[22].message = "Encryption protects data by converting it into a secure format.";

            responses[23] = new Response();
            responses[23].keyword = "hacker";
            responses[23].message = "Hackers attempt to gain unauthorized access to systems.";

            responses[24] = new Response();
            responses[24].keyword = "breach";
            responses[24].message = "A data breach occurs when sensitive data is exposed.";

            responses[25] = new Response();
            responses[25].keyword = "security";
            responses[25].message = "Cybersecurity protects systems, networks, and data.";

            responses[26] = new Response();
            responses[26].keyword = "online";
            responses[26].message = "Always be cautious when sharing information online.";

            responses[27] = new Response();
            responses[27].keyword = "download";
            responses[27].message = "Only download files from trusted sources.";

            responses[28] = new Response();
            responses[28].keyword = "device";
            responses[28].message = "Secure your devices with passwords or biometrics.";

            responses[29] = new Response();
            responses[29].keyword = "account";
            responses[29].message = "Protect your accounts with strong passwords and 2FA.";

            bool chatting = true;

            while (chatting)
            {

                //this line displays the username perpetually.
                Console.Write(userName + ": ");


                string userInput = (Console.ReadLine() ?? "").ToLower().Trim();


                //This line checks if user put anything, and prompts them to enter something 
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                //simple string comparison to check exit to trigger break 
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FiggleFonts.Small.Render("Goodbye!"));
                    Console.ResetColor();

                    Console.WriteLine("Bot: Goodbye " + userName + "! Stay safe online.");
                    break;
                }

                bool found = false;

                for (int i = 0; i < responses.Length; i++)
                {
                    if (userInput.Contains(responses[i].keyword)) // String search using Contains() method (W3Schools, 2024)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        //Because we know the index above for the found key word, we are able to display the message for the same index since its the smae position
                        Console.WriteLine("Bot: " + responses[i].message);
                        Console.ResetColor();

                        //
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: I'm not sure I understand. Try asking about cybersecurity topics.");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
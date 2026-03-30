using System;
using System.Linq;

namespace CyberSecurityChatbot
{
    class UserInteraction
    {
        public static string GetUserName()
        {
            while (true)
            {
                Console.Write("Please enter your name: ");

                string name = (Console.ReadLine() ?? "").Trim();

                if (!string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter)) // String validation using C# methods (GeeksforGeeks, 2024)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hello " + name + "! Welcome to the Cybersecurity Awareness Chatbot.");
                    Console.WriteLine();

                    return name; // only return when valid
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid name. Please use letters only.");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
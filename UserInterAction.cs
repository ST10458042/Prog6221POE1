using System;

namespace CyberSecurityChatbot
{
    class UserInteraction
    {
        public static string GetUserName()
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hello " + name + "! Welcome to the Cybersecurity Awareness Chatbot.");
            Console.WriteLine();

            return name;
        }
    }
}
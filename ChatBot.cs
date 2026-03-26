using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityChatBot
{
    internal class ChatBot
    {
        public static void StartChat(string userName)
        {
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("- phishing");
            Console.WriteLine("- passwords");
            Console.WriteLine("- safe browsing");
            Console.WriteLine();

            Console.Write("Ask a question: ");

            string question = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thanks for your question! I will learn how to answer that soon.");

        }
    }
}

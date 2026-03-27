
using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            VisualDisplay.ShowLogo();

            string userName = UserInteraction.GetUserName();

            Chatbot.StartChat(userName);
        }
    }
}
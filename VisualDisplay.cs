using System;

namespace CyberSecurityChatbot
{
    class VisualDisplay
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("======================================");
            Console.WriteLine("     CYBERSECURITY AWARENESS BOT      ");
            Console.WriteLine("======================================");
            Console.WriteLine("        Stay Safe Online              ");
            Console.WriteLine("======================================");

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
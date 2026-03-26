using System;
using Figgle;
using Figgle.Fonts;

namespace CyberSecurityChatbot
{
    class VisualDisplay
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string title = "CYBERSECURITY";
            string title2 = "AWARENESS";
            string title3 = "BOT";

            Console.WriteLine();
            Console.WriteLine(FiggleFonts.Standard.Render(title));
            Console.WriteLine(FiggleFonts.Standard.Render(title2));
            Console.WriteLine(FiggleFonts.Standard.Render(title3));

            Console.ResetColor();

            Console.WriteLine("===============================================");
            Console.WriteLine(" Welcome to the Cybersecurity Awareness Chatbot");
            Console.WriteLine("===============================================");
            Console.WriteLine();
        }
    }
}
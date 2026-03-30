using Figgle;
using Figgle.Fonts;
using System;

namespace CyberSecurityChatbot
{
    class VisualDisplay
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            // Figgle ASCII art title
            Console.WriteLine(FiggleFonts.Small.Render("Cybersecurity"));
            Console.WriteLine(FiggleFonts.Small.Render("Awareness Bot ")); // ASCII text rendering using Figgle library (Figgle, 2023)

            // ASCII art generated using Patorjk tool (Patorjk, 2025)
            Console.WriteLine(@"
        ______________________
       |                      |
       |      WELCOME TO      |
       |      CYBERSECURITY   |
       |          BOT         |
       |______________________|
              ||
              ||
         .-""""""-.
        /          \
       |  O      O  |
       |   ----     | 
       |   \____/   |
        \__________/
          /|    |\
         / |    | \
           |    |
          /      \
         /_/\/\_\

     
");

            Console.ResetColor();
        }
    }
}
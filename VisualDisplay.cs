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
            Console.WriteLine(FiggleFonts.Standard.Render("Cybersecurity"));
            Console.WriteLine(FiggleFonts.Standard.Render("Awareness Bot "));

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
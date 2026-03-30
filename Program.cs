using CyberSecurityChatbot;

namespace CyberSecurityChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //firstly display logo from the VisualDisplay Class, accessible due to static key word.
            VisualDisplay.ShowLogo(); //

            // Play audio from the voice class, accessible globally due to static key word
            voice.VocalPlayer();

            string userName = UserInteraction.GetUserName();
            //
            Chatbot.StartChat(userName);


            //This pauses the program before it closes,to prevent the console from closing automatically
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
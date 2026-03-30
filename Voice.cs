using System.Media;

namespace CyberSecurityChatbot
{

    class voice()
    {




        public static void VocalPlayer()
        {
            try
            {
                // Audio playback using SoundPlayer class (Microsoft, 2024)
                using (SoundPlayer player = new SoundPlayer("Helo.WAV")) // Voice file generated using AI voice tool (Musley AI, 2025)
                {
                    player.PlaySync();
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
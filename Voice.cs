using System.Media;

namespace CyberSecurityChatbot
{

    class voice()
    {




        public static void VocalPlayer()
        {
            try
            {

                using (SoundPlayer player = new SoundPlayer("Helo.WAV"))
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
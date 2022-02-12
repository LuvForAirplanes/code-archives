using System.IO;
using System.Media;

namespace Pronect.Services
{
    /// <summary>
    /// The beauty of sound... Play sounds from Pronect. Your own, or, from a list of predifined ones...
    /// </summary>
    static class Sound
    {
        /// <summary>
        /// The possible sounds to be played from <see cref="Play(Sounds)"/>.
        /// </summary>
        public enum Sounds
        {
            Alarm01,
            Alarm02,
            Alarm03,
            Alarm04,
            Alarm05,
            Alarm06,
            Alarm07,
            Alarm08,
            Alarm09,
            Alarm10,
            chimes,
            chord,
            ding,
            ir_begin,
            ir_end,
            ir_inter,
            notify,
            recycle,
            Ring01,
            Ring02,
            Ring03,
            Ring04,
            Ring05,
            Ring06,
            Ring07,
            Ring08,
            Ring09,
            Ring10,
            ringout
        }
        /// <summary>
        /// Play sound from a file path on the local machine
        /// </summary>
        public static void Play(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\media\Alarm01.wav");
            player.Play();
        }
        /// <summary>
        /// Play sound from a byte[] array.
        /// </summary>
        /// <param name="audioData"></param>
        public static void Play(byte[] audioData)
        {
            using (MemoryStream ms = new MemoryStream(audioData))
            {
                SoundPlayer player = new SoundPlayer(ms);
                player.Play();
            }
        }
        /// <summary>
        /// Play a sound from <see cref="Sounds"/>
        /// </summary>
        /// <param name="sound"></param>
        public static void Play(Sounds sound)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Windows\media\" + sound + ".wav");
            player.Play();
        }
    }
}

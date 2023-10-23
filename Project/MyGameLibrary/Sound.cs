using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyGameLibrary
{

    public class Sound
    {
        private SoundPlayer song;
        public Sound()
        {
        }
        /// <summary>
        /// Plays provided sound file.
        /// </summary>
        /// <param name="music">Name of sound file</param>
        public void Play(UnmanagedMemoryStream music)
        {
            song = new SoundPlayer(music);
            song.PlayLooping();
        }
        /// <summary>
        ///  Stops provided sound file
        /// </summary>
        public void Stop()
        {
            song.Stop();
            song.Dispose();
        }

        public void SetVolume(int volume)
        {
            // todo
        }
    }
}



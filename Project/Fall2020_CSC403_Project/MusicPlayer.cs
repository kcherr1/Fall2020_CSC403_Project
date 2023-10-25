using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class MusicPlayer
    {
        private static SoundPlayer footstepSound;
        private static SoundPlayer levelSound;
        private static SoundPlayer attackSound;
        private static SoundPlayer titleSound;
        public static void PlayFootsteps()
        {
            footstepSound = new SoundPlayer(Resources.footsteps);
            footstepSound.Play();
        }

        public static void PlayLevelMusic()
        {
            levelSound = new SoundPlayer(Resources.background);
            levelSound.PlayLooping();
        }

        public static void StopLevelMusic()
        {
            levelSound.Stop();
        }

        public static void PlayDamageSound()
        {
            attackSound = new SoundPlayer(Resources.oof);
            attackSound.Play();
        }

        public static void PlayTitleSound()
        {
            titleSound = new SoundPlayer(Resources.title);
            titleSound.PlayLooping();
        }

        public static void StopTitleSound()
        {
            titleSound.Stop();
        }
    }

    
}

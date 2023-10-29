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
        private static SoundPlayer levelSound = new SoundPlayer(Resources.background);
        private static SoundPlayer gameOverSound = new SoundPlayer(Resources.game_over);
        private static SoundPlayer titleSound = new SoundPlayer(Resources.title);
        private static SoundPlayer battleSound = new SoundPlayer(Resources.battle);
        private static SoundPlayer bossBattleSound = new SoundPlayer(Resources.boss_battle);

        public static void PlayLevelMusic()
        {
            levelSound.PlayLooping();
        }

        public static void StopLevelMusic()
        {
            levelSound.Stop();
        }

        public static void PlayTitleSound()
        {
            titleSound.PlayLooping();
        }

        public static void StopTitleSound()
        {
            titleSound.Stop();
        }

        public static void PlayGameOverSound()
        {
            gameOverSound.Play();
        }

        public static void PlayBattleSound()
        {
            battleSound.PlayLooping();
        }

        public static void StopBattleSound()
        {
            battleSound.Stop();
        }



    }

    
}

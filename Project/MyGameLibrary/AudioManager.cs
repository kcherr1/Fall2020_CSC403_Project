using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class AudioManager
    {
        private static AudioManager instance;
        private Dictionary<string, SoundPlayer> soundPlayer; 

        private AudioManager() { 
            soundPlayer = new Dictionary<string, SoundPlayer>();
        }


        public void AddSound(string soundName, System.Media.SoundPlayer soundPath)
        {
            if (!soundPlayer.ContainsKey(soundName))
            {
                soundPlayer.Add(soundName, soundPath);
            }
        }
        public static AudioManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AudioManager();
                }
                return instance;
            }
        }

        public void PlaySound(string soundName)
        {
            if (soundPlayer.ContainsKey(soundName))
            {
                soundPlayer[soundName].Play();
            }
        }

        public void PlaySoundLoop(string soundName)
        {
            if (soundPlayer.ContainsKey(soundName))
            {
                soundPlayer[soundName].PlayLooping();
            }
        }

        public void StopSound(string soundName)
        {
            if (soundPlayer.ContainsKey(soundName)) 
            {
                soundPlayer[soundName].Stop();
            }
        }

    }
}

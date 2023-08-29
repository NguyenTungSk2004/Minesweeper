using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class SoundManager
    {
        private SoundPlayer player;

        public SoundManager()
        {
            player = new SoundPlayer();
        }

        public void PlaySound(string soundLocation)
        {
            player.SoundLocation = soundLocation;
            player.Play();
        }

        public void PlaySoundLooping(string soundLocation)
        {
            player.SoundLocation = soundLocation;
            player.PlayLooping();
        }

        public void StopSound()
        {
            player.Stop();
        }
    }
}

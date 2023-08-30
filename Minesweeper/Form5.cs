using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen; 
            Music.CheckedChanged += new EventHandler(MusicCheckBox_CheckedChanged);
            Music.Checked = Form2.isMusicOn;
        }
        public class SoundManager
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

        private void MusicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SoundManager soundManager = new SoundManager();
            if (Music.Checked)
            {
                string netWindows = Path.GetDirectoryName(Application.ExecutablePath);
                string Debug = Directory.GetParent(netWindows).FullName;
                string bin = Directory.GetParent(Debug).FullName;
                string Minesweeper = Directory.GetParent(bin).FullName;
                string path = Path.Combine(Minesweeper, "Resources", "NhacNen.wav");
                if(Form2.isMusicOn != true ) soundManager.PlaySoundLooping(path);
            }
            else
            {
                soundManager.StopSound();
            }
            Form2.isMusicOn = Music.Checked;
        }

    }

}

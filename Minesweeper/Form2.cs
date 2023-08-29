using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form2 : Form
    {
        private SoundManager soundManager;
        public static bool isMusicOn = true;
        public Form2()
        {
            InitializeComponent();
            soundManager = new SoundManager();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void settings_click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(btn1_Click);
            btn2.Click += new EventHandler(btn2_Click);
            btn3.Click += new EventHandler(btn3_Click);
            Exit.Click += new EventHandler(exit);
            settings.Click += new EventHandler(settings_click);
            FistloadMusic();
        }

        private void FistloadMusic()
        {
            if (isMusicOn)
            {
                string netWindows = Path.GetDirectoryName(Application.ExecutablePath);
                string Debug = Directory.GetParent(netWindows).FullName;
                string bin = Directory.GetParent(Debug).FullName;
                string Minesweeper = Directory.GetParent(bin).FullName;
                string path = Path.Combine(Minesweeper, "Resources", "NhacNen.wav");
                soundManager.PlaySoundLooping(path);
            }
        }
    }
}

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
    /// <summary>
    /// Form giao diện khởi đầu
    /// </summary>
    public partial class Form2 : Form
    {
        private SoundManager soundManager;
        public static bool isMusicOn = true;
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            soundManager = new SoundManager();
        }

        // Level 10x10
        private void btn1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        //Level 12x12
        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        //Level15x15
        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        //Nút thoát
        private void exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        //Nút settings
        private void settings_click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        //Hàm kết nối âm thanh
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

        /// <summary>
        /// Khi form được load thì bắt đầu thêm các sự kiện và chạy âm thanh
        /// Điều này hạn chế việc khi quay lại form này từ form khác các sự kiện không còn hoạt động 
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(btn1_Click);
            btn2.Click += new EventHandler(btn2_Click);
            btn3.Click += new EventHandler(btn3_Click);
            Exit.Click += new EventHandler(exit);
            settings.Click += new EventHandler(settings_click);
            FistloadMusic();
        }

    }
}

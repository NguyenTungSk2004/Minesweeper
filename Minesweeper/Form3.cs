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
    /// Form giao diện level 12x12
    /// </summary>
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            time timer = new time(timeView);
            functions function = new functions(this, "Form3");
            function.FillGroupGame(groupGameForm2, 12, 12);
            timer.startTimer();
            home.Click += new EventHandler(BackHome);
            settings.Click += new EventHandler(settings_Click);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void BackHome(object sender, EventArgs e)
        {
            functions function = new functions(this, "Form1");
            function.buttonsClear();
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}

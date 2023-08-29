﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            time timer = new time(this, timeView);
            functions function = new functions(this, "Form4");
            function.FillGroupGame(groupGameForm3, 15, 15);
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

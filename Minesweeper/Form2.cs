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
        public Form2()
        {
            InitializeComponent();
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
            Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(btn1_Click);
            btn2.Click += new EventHandler(btn2_Click);
            btn3.Click += new EventHandler(btn3_Click);
            Exit.Click += new EventHandler(exit);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class time
    {
        public Form form;
        public Label label;
        private System.Windows.Forms.Timer timer;
        private int giay = 0;
        private int phut = 0;
        private bool isGameOver = false;
        public event EventHandler GameOverEvent;

        public time (Form form, Label label)
        {
            this.form = form;
            this.label = label;

        }

        internal void startTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Đặt khoảng thời gian giữa các lần Tick là 1 giây
            timer.Tick += timer3_Tick;
            timer.Start();
        }
        internal void Function_GameOverEvent()
        {
            timer.Stop();
            isGameOver = true;
            hienthigio();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                giay++;
                if (giay >= 60)
                {
                    giay = 0;
                    phut++;
                }
                hienthigio();
            }

        }
        private void hienthigio()
        {
            label.Text = $"{phut:D2}:{giay:D2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class ColorChanged
    {
        internal void changeColor(object sender)
        {
            Button button = (Button)sender;
            button.Image = null;
            if ((int)button.Tag == 1) button.ForeColor = Color.IndianRed;
            if ((int)button.Tag == 2) button.ForeColor = Color.Blue;
            if ((int)button.Tag == 3) button.ForeColor = Color.Green;
            if ((int)button.Tag == 4) button.ForeColor = Color.Violet;
            if ((int)button.Tag == 5) button.ForeColor = Color.Teal;
            if ((int)button.Tag == 6) button.ForeColor = Color.Yellow;
            if ((int)button.Tag != 0)
            {
                button.Text = button.Tag.ToString();
                button.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            else
            {
                button.BackColor = Color.Gray;
                button.Enabled = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Auto
    {
        List<Button> buttons = functions.buttons;
        internal void autoClick(object sender, MouseEventArgs e, int rows, int columns, int test)
        {
            Button btn = (Button)sender;
            int index = btn.TabIndex;
            if ((int)btn.Tag == 0)
            {
                btn.Text = "";
                if (btn.Enabled == true)
                {
                    btn.Image = null;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;

                    //Góc trên bên trái 
                    if (btn.TabIndex == 0)
                    {
                        if ((int)buttons[index + 1].Tag != -1) autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns + 1].Tag != -1) autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                    }
                    //Góc trên bên phải
                    else if (btn.TabIndex == columns - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + columns].Tag != -1) autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);

                    }
                    //Góc dưới bên trái 
                    else if (btn.TabIndex == columns * rows - columns)
                    {
                        if ((int)buttons[index + 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, 1);
                        if ((int)buttons[index - columns].Tag != -1) autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns + 1].Tag != -1) autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Góc dưới bên phải
                    else if (btn.TabIndex == columns * rows - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index - columns].Tag != -1) autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }
                    //Là cột phải
                    else if ((btn.TabIndex + 1) % columns == 0)
                    {
                        if ((int)buttons[index - 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + columns].Tag != -1) autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        if ((int)buttons[index - columns].Tag != -1) autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }

                    //Là cột trái
                    else if (btn.TabIndex % columns == 0)
                    {
                        if ((int)buttons[index + 1].Tag != -1) autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns + 1].Tag != -1) autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                        if ((int)buttons[index - columns].Tag != -1) autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns + 1].Tag != -1) autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Là hàng duới cùng
                    else if (btn.TabIndex > columns * rows - columns && btn.TabIndex <= columns * rows - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + 1].Tag != -1) autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index - columns].Tag != -1) autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                        if ((int)buttons[index - columns + 1].Tag != -1) autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Là hàng trên cùng
                    else if (btn.TabIndex >= 0 && btn.TabIndex < columns)
                    {
                        if ((int)buttons[index - 1].Tag != -1) autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + 1].Tag != -1) autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        if ((int)buttons[index + columns + 1].Tag != -1) autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                    }
                    //Các trường hợp còn lại
                    else
                    {
                        autoClick(buttons[index + 1], e, rows, columns, 1);
                        autoClick(buttons[index - 1], e, rows, columns, -1);
                        autoClick(buttons[index - columns], e, rows, columns, -columns);
                        autoClick(buttons[index + columns], e, rows, columns, columns);
                        autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                        autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                        autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }
                }
            }
            else
            {
                ColorChanged func = new ColorChanged();
                func.changeColor(btn);
            }
        }


    }
}

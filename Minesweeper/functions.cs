﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Minesweeper
{
    internal class functions
    {
        public Form form;
        public time timer;
        private ColorChanged color = new ColorChanged();
        public static List<Button> buttons = new List<Button>();
       
        public string checkForm;
        private bool ktr = false;

        Random random = new Random();
        Auto auto = new Auto();

        //Contructor chính dùng để khởi tạo game
        public functions(Form form, string check, time timer)
        {
            this.form = form;
            this.checkForm = check;
            this.timer = timer;
        }

        //Contructor này có nhằm mục đích sử dụng hàm ButtonClear()
        public functions(Form form, string check)
        {
            this.form = form;
            this.checkForm = check;
        }

        /// <summary>
        /// Hàm chính thực hiện toàn bộ class functions khi gọi đến nó.
        /// Hàm này sẽ điền đầy GroupBox bằng các button là các ô của trò chơi
        /// </summary>
        public void FillGroupGame(GroupBox groupBox, int rows, int columns)
        {
            int buttonWidth = groupBox.Width / columns;
            int buttonHeight = groupBox.Height / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Width = buttonWidth;
                    button.Height = buttonHeight;
                    button.Location = new Point(j * buttonWidth + 3, i * buttonHeight + 4);
                    button.FlatStyle = FlatStyle.Popup;
                    button.FlatAppearance.BorderSize = 0; 
                    button.BackColor = Color.LightGray;
                    button.TabIndex = i * columns + j;
                    groupBox.Controls.Add(button);
                }
            }

            RanDomBoom(groupBox, rows, columns);
        }

        /// <summary>
        /// Hàm RanDomBoom khởi tạo các ô chưa có boom và gán sự kiện khi click vào ô không có boom cho chúng
        /// sau đó tạo ra ngẫu nhiên boom ở ngẫu nhiên ô và gán sự kiện khi click vào boom cho chúng
        /// Tiếp đến với những button.Tag != -1 thì ta gán hàm checkBoom cho chúng để khởi tạo số lượng boom xung quanh ô đó
        /// 
        /// Chú thích:
        /// button.Tag biểu thị số lượng boom ở xung quanh ô đó 
        /// {-1: ô đó là boom, 0: xung quanh không có boom, 1: là xung quanh có 1 quả boom,...}
        /// </summary>
        public void RanDomBoom(GroupBox groupBox, int rows, int columns)
        {
            int soLuong = (rows *columns)*20/100;

            foreach (Control control in groupBox.Controls)
            {
                if (control is Button)
                {
                    Button push = (Button) control;
                    push.Tag = 0;
                    push.MouseDown += (sender, e) => notBoom(sender, e, rows, columns);
                    buttons.Add(push);
                }
            }

            for(int i = 0; i < soLuong ; i++)
            {
                int index = random.Next(0, buttons.Count);
                buttons[index].Tag = -1;
                buttons[index].MouseDown += (sender, e) => Boom(sender, e);
            }

            foreach (Button button in buttons)
            {
                if((int)button.Tag != -1) button.Tag = checkBoom(button, rows, columns);
            }
        }

        /// <summary>
        /// Hàm checkBoom này trả về số lượng boom xung quanh ô
        /// </summary>
        private int checkBoom(Button button,  int rows, int columns)
        {
            int boom = 0;
            int index = button.TabIndex;
            int trenTrai = 0;
            int trenPhai = columns - 1;
            int duoiPhai = columns * rows - 1;
            int duoiTrai = columns * rows - columns;

            //Góc phía trên bên trái
            if (index == trenTrai)
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index + columns + 1].Tag == -1) boom++;
            }
            //Góc phía trên bên phải
            else if (index == trenPhai)
            {
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index + columns - 1].Tag == -1) boom++;
            }
            //Góc phía dưới bên phải
            else if (index == duoiPhai)
            {
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index - columns - 1].Tag == -1) boom++;
            }
            //Góc phía dưới bên trái
            else if (index == duoiTrai)
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index - columns + 1].Tag == -1) boom++;
            }
            //Hàng trên cùng
            else if (index > trenTrai && index < trenPhai)
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index + columns + 1].Tag == -1) boom++;
                if ((int)buttons[index + columns - 1].Tag == -1) boom++;
            }
            //Cột bên trái
            else if (index% columns == 0)
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index + columns + 1].Tag == -1) boom++;
                if ((int)buttons[index - columns + 1].Tag == -1) boom++;
            }
            //Cột bên phải
            else if ((index +1)% columns == 0)
            {
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index + columns - 1].Tag == -1) boom++;
                if ((int)buttons[index - columns - 1].Tag == -1) boom++;
            }
            //Hàng dưới cùng
            else if (index > duoiTrai && index < duoiPhai)
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index - columns + 1].Tag == -1) boom++;
                if ((int)buttons[index - columns - 1].Tag == -1) boom++;
            }
            //Trường hợp còn lại
            else
            {
                if ((int)buttons[index + 1].Tag == -1) boom++;
                if ((int)buttons[index - 1].Tag == -1) boom++;
                if ((int)buttons[index - columns].Tag == -1) boom++;
                if ((int)buttons[index - columns + 1].Tag == -1) boom++;
                if ((int)buttons[index - columns - 1].Tag == -1) boom++;
                if ((int)buttons[index + columns].Tag == -1) boom++;
                if ((int)buttons[index + columns + 1].Tag == -1) boom++;
                if ((int)buttons[index + columns - 1].Tag == -1) boom++;
            }
            return boom ;
        }



        //Hàm sự kiện những button không có boom
        internal void notBoom(object sender, MouseEventArgs e, int rows, int columns)
        {
            Button btn = (Button)sender;
            int index = btn.TabIndex;
            if (e.Button == MouseButtons.Left)
            {
                if ((int)btn.Tag == 0 && btn.Enabled == true)
                {
                    btn.Text = "";
                    btn.Image = null;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    
                    //Góc trên bên trái 
                    if (btn.TabIndex == 0)
                    {
                        if ((int)buttons[index + 1].Tag != -1) auto.autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns + 1].Tag != -1) auto.autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                    }
                    //Góc trên bên phải
                    else if (btn.TabIndex == columns - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + columns].Tag != -1) auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) auto.autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);

                    }
                    //Góc dưới bên trái 
                    else if (btn.TabIndex == columns * rows - columns)
                    {
                        if ((int)buttons[index + 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, 1);
                        if ((int)buttons[index - columns].Tag != -1) auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns + 1].Tag != -1) auto.autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Góc dưới bên phải
                    else if (btn.TabIndex == columns * rows - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index - columns].Tag != -1) auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) auto.autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }
                    //Là cột phải
                    else if ((btn.TabIndex + 1) % columns == 0)
                    {
                        if ((int)buttons[index - 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + columns].Tag != -1) auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) auto.autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        if ((int)buttons[index - columns].Tag != -1) auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) auto.autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }

                    //Là cột trái
                    else if (btn.TabIndex % columns == 0)
                    {
                        if ((int)buttons[index + 1].Tag != -1) auto.autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns + 1].Tag != -1) auto.autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                        if ((int)buttons[index - columns].Tag != -1) auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns + 1].Tag != -1) auto.autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Là hàng duới cùng
                    else if (btn.TabIndex > columns * rows - columns && btn.TabIndex <= columns * rows - 1)
                    {
                        if ((int)buttons[index - 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + 1].Tag != -1) auto.autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index - columns].Tag != -1) auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        if ((int)buttons[index - columns - 1].Tag != -1) auto.autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                        if ((int)buttons[index - columns + 1].Tag != -1) auto.autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                    }
                    //Là hàng trên cùng
                    else if (btn.TabIndex >= 0 && btn.TabIndex < columns)
                    {
                        if ((int)buttons[index - 1].Tag != -1) auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        if ((int)buttons[index + 1].Tag != -1) auto.autoClick(buttons[index + 1], e, rows, columns, 1);
                        if ((int)buttons[index + columns].Tag != -1) auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        if ((int)buttons[index + columns - 1].Tag != -1) auto.autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        if ((int)buttons[index + columns + 1].Tag != -1) auto.autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                    }
                    //Các trường hợp còn lại
                    else
                    {
                        auto.autoClick(buttons[index + 1], e, rows, columns, 1);
                        auto.autoClick(buttons[index - 1], e, rows, columns, -1);
                        auto.autoClick(buttons[index - columns], e, rows, columns, -columns);
                        auto.autoClick(buttons[index + columns], e, rows, columns, columns);
                        auto.autoClick(buttons[index + columns + 1], e, rows, columns, columns + 1);
                        auto.autoClick(buttons[index + columns - 1], e, rows, columns, columns - 1);
                        auto.autoClick(buttons[index - columns + 1], e, rows, columns, -columns + 1);
                        auto.autoClick(buttons[index - columns - 1], e, rows, columns, -columns - 1);
                    }
                }
                else
                {
                    color.changeColor(btn);
                }
                GameVictory();
            }
            else if (e.Button == MouseButtons.Right)
            {
                btn.Text = "";
                string Minesweeper = createPathToResources();
                if (btn.Image == null)
                {
                    string imagePath = Path.Combine(Minesweeper, "flag.png");
                    btn.Image = Image.FromFile(imagePath);
                }
                else
                {
                    btn.Image = null;
                }
            }
        }
        //Hàm sự kiện cho những button có boom
        private void Boom(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            string Minesweeper = createPathToResources();
            if (e.Button == MouseButtons.Left)
            { 
                foreach(Button button in buttons)
                {
                    if((int)button.Tag == -1)
                    {
                        button.Text = "";
                        string imagePath = Path.Combine(Minesweeper, "boom.png");
                        button.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        color.changeColor(button);
                    }
                }
                GameOver();
            }
            else if(e.Button == MouseButtons.Right)
            {
                btn.Text = "";
                if (ktr == false)
                {
                    ktr = true;
                    string imagePath = Path.Combine(Minesweeper, "flag.png");
                    btn.Image = Image.FromFile(imagePath);
                }
                else
                {
                    ktr = false;
                    btn.Image = null;
                }
            }
        }

        /// <summary>
        /// Khi chiến thắng game thì hiện hộp thoại thông báo chiến thắng, sau đó hiển thị hộp thoại hỏi bạn có muốn 
        /// chơi tiếp màn tiếp theo hay không, hay muốn chơi lại, hay quay về màn hình chính.
        /// Nếu là màn cuối thì sau khi ấn ok sẽ quay trở về màn hình chính
        /// </summary>
        private void GameVictory()
        {
            bool victory = true;
            foreach(Button button in buttons)
            {
                if((int)button.Tag != -1 && (int)button.Tag != 0)
                {
                    if (string.IsNullOrEmpty(button.Text))
                    {
                        victory = false;
                    }
                }
            }
            if (victory == true)
            {
                highscore highscore = new highscore();
                timer.StopTimer();
                highscore.saveHighScore(checkForm, timer);
                if (checkForm != "Form4")
                {
                    DialogResult result = MessageBox.Show("Bạn đã chiến thắng !", "Victory", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có muốn tiếp tục không?", "Question", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Cancel)
                        {
                            buttons.Clear();
                            form.Hide();
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                            form.Close();
                        }
                        else if (dialog == DialogResult.Continue)
                        {
                            //chuyển sang form level tiếp theo
                            buttons.Clear();
                            form.Hide();
                            if (checkForm == "Form1")
                            {
                                Form3 form3 = new Form3();
                                form3.ShowDialog();
                            }
                            if (checkForm == "Form3")
                            {
                                Form4 form4 = new Form4();
                                form4.ShowDialog();
                            }
                            form.Close();
                        }
                        else if (dialog == DialogResult.TryAgain)
                        {
                            buttons.Clear();
                            form.Hide();
                            if (checkForm == "Form1")
                            {
                                Form1 form1 = new Form1();
                                form1.ShowDialog();
                            }
                            else if (checkForm == "Form3")
                            {
                                Form3 form3 = new Form3();
                                form3.ShowDialog();
                            }
                            else if (checkForm == "Form4")
                            {
                                Form4 form4 = new Form4();
                                form4.ShowDialog();
                            }
                            form.Close();
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn đã chiến thắng !", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                    if(result == DialogResult.Retry)
                    {
                        buttons.Clear();
                        form.Hide();
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        form.Close();
                    }
                    else
                    {
                        buttons.Clear();
                        form.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        form.Close();
                    }

                }
            }
        }

        /// <summary>
        /// Khi bạn ấn vào boom sẽ hiện lên thông báo chơi lại hay quay trở lại màn hình chính
        /// </summary>
        private void GameOver()
        {
            timer.StopTimer();
            DialogResult result = MessageBox.Show("Bạn đã dính boom !", "GameOver", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            if(result == DialogResult.Retry)
            {
                buttons.Clear();
                form.Hide();
                if (checkForm == "Form1")
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                else if (checkForm == "Form3")
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else if (checkForm == "Form4")
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                }
                form.Close();
            }
            else if(result == DialogResult.Cancel)
            {
                buttons.Clear();
                form.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form.Close();
            }
        }

        /// <summary>
        /// Phương thức buttonsClear() hiện chỉ được sử dụng cho nút BackHome
        /// </summary>
        public void buttonsClear()
        {
            buttons.Clear();
        }

        /// <summary>
        /// Hàm đươc sử dụng để tạo đường dẫn đến thư mục Resources chứa file ảnh và âm thanh
        /// </summary>
       private string createPathToResources()
        {
            string netWindows = Path.GetDirectoryName(Application.ExecutablePath);
            string Debug = Directory.GetParent(netWindows).FullName;
            string bin = Directory.GetParent(Debug).FullName;
            string Minesweeper = Directory.GetParent(bin).FullName;
            string path = Path.Combine(Minesweeper, "Resources");
            return path;
        }
    }
}

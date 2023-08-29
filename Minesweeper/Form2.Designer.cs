namespace Minesweeper
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button4 = new Button();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Wheat;
            btn1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(299, 106);
            btn1.Name = "btn1";
            btn1.Size = new Size(211, 53);
            btn1.TabIndex = 1;
            btn1.Text = "10 x 10";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Chocolate;
            btn2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(299, 193);
            btn2.Name = "btn2";
            btn2.Size = new Size(211, 49);
            btn2.TabIndex = 1;
            btn2.Text = "12 x 12";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Chartreuse;
            btn3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(300, 289);
            btn3.Name = "btn3";
            btn3.Size = new Size(211, 50);
            btn3.TabIndex = 1;
            btn3.Text = "15 x 15";
            btn3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(212, 382);
            button4.Name = "button4";
            button4.Size = new Size(129, 56);
            button4.TabIndex = 2;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Location = new Point(455, 382);
            Exit.Name = "Exit";
            Exit.Size = new Size(129, 56);
            Exit.TabIndex = 2;
            Exit.Text = "Thoát ";
            Exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Chocolate;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.tai_ngay_100_hinh_nen_3_chu_gau_we_bare_bear_de_thuong_2021_2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(180, 28);
            label1.Name = "label1";
            label1.Size = new Size(454, 53);
            label1.TabIndex = 4;
            label1.Text = "Mời bạn chọn độ khó";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(button4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button button4;
        private Button Exit;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
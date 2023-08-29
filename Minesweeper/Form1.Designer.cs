namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupGameForm1 = new GroupBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timeView = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupGameForm1
            // 
            groupGameForm1.Location = new Point(95, 82);
            groupGameForm1.Name = "groupGameForm1";
            groupGameForm1.Size = new Size(494, 507);
            groupGameForm1.TabIndex = 0;
            groupGameForm1.TabStop = false;
            groupGameForm1.Text = "10 x 10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // timeView
            // 
            timeView.BackColor = SystemColors.InactiveBorder;
            timeView.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            timeView.Location = new Point(495, 17);
            timeView.Name = "timeView";
            timeView.Size = new Size(165, 44);
            timeView.TabIndex = 5;
            timeView.Text = "Thời gian";
            timeView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._2bf5a717f4380fc0a293606663481c8a;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 601);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(273, 17);
            label2.Name = "label2";
            label2.Size = new Size(165, 44);
            label2.TabIndex = 5;
            label2.Text = "Minesweeper";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.InactiveBorder;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 17);
            label3.Name = "label3";
            label3.Size = new Size(165, 44);
            label3.TabIndex = 5;
            label3.Text = "Lần ấn";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(700, 601);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(timeView);
            Controls.Add(label1);
            Controls.Add(groupGameForm1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Minesweeper";
            TransparencyKey = Color.Red;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupGameForm1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label timeView;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}
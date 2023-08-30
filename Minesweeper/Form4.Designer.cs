namespace Minesweeper
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            groupGameForm3 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timeView = new Label();
            highScore = new Label();
            settings = new Button();
            home = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupGameForm3
            // 
            groupGameForm3.Location = new Point(157, 141);
            groupGameForm3.Name = "groupGameForm3";
            groupGameForm3.Size = new Size(741, 761);
            groupGameForm3.TabIndex = 0;
            groupGameForm3.TabStop = false;
            groupGameForm3.Text = "15 x 15";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 38);
            label1.Name = "label1";
            label1.Size = new Size(282, 77);
            label1.TabIndex = 1;
            label1.Text = "15x15";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Phong_cảnh_thiên_nhiên_làm_hình_nền_đẹp_cho_máy_tính_scaled;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1059, 925);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timeView
            // 
            timeView.BackColor = SystemColors.ControlLightLight;
            timeView.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            timeView.Location = new Point(718, 38);
            timeView.Name = "timeView";
            timeView.Size = new Size(282, 77);
            timeView.TabIndex = 1;
            timeView.Text = "Time";
            timeView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highScore
            // 
            highScore.BackColor = SystemColors.ControlLightLight;
            highScore.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            highScore.Location = new Point(73, 38);
            highScore.Name = "highScore";
            highScore.Size = new Size(282, 77);
            highScore.TabIndex = 1;
            highScore.Text = "HighScore";
            highScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settings
            // 
            settings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            settings.Location = new Point(956, 874);
            settings.Name = "settings";
            settings.Size = new Size(103, 51);
            settings.TabIndex = 9;
            settings.Text = "Settings";
            settings.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            home.BackColor = SystemColors.InactiveBorder;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            home.Image = (Image)resources.GetObject("home.Image");
            home.Location = new Point(0, 881);
            home.Name = "home";
            home.Size = new Size(90, 44);
            home.TabIndex = 8;
            home.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1059, 925);
            Controls.Add(settings);
            Controls.Add(home);
            Controls.Add(groupGameForm3);
            Controls.Add(highScore);
            Controls.Add(timeView);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Minesweeper";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupGameForm3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label timeView;
        private Label highScore;
        private Button settings;
        private Label home;
    }
}
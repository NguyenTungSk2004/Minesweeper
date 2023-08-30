namespace Minesweeper
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            groupGameForm2 = new GroupBox();
            timeView = new Label();
            label2 = new Label();
            highScore = new Button();
            pictureBox1 = new PictureBox();
            settings = new Button();
            home = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupGameForm2
            // 
            groupGameForm2.Location = new Point(118, 111);
            groupGameForm2.Name = "groupGameForm2";
            groupGameForm2.Size = new Size(593, 608);
            groupGameForm2.TabIndex = 0;
            groupGameForm2.TabStop = false;
            groupGameForm2.Text = "12 x 12";
            // 
            // timeView
            // 
            timeView.BackColor = SystemColors.ControlLight;
            timeView.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            timeView.Location = new Point(574, 24);
            timeView.Name = "timeView";
            timeView.Size = new Size(204, 67);
            timeView.TabIndex = 1;
            timeView.Text = "Time";
            timeView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Enabled = false;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(327, 24);
            label2.Name = "label2";
            label2.Size = new Size(200, 68);
            label2.TabIndex = 1;
            label2.Text = "Minesweeper";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highScore
            // 
            highScore.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            highScore.Location = new Point(87, 25);
            highScore.Name = "highScore";
            highScore.Size = new Size(188, 67);
            highScore.TabIndex = 3;
            highScore.Text = "HighScore";
            highScore.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ảnh_nền_cực_độc_dáo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 731);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // settings
            // 
            settings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            settings.Location = new Point(741, 680);
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
            home.Location = new Point(0, 687);
            home.Name = "home";
            home.Size = new Size(90, 44);
            home.TabIndex = 8;
            home.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 731);
            Controls.Add(settings);
            Controls.Add(home);
            Controls.Add(highScore);
            Controls.Add(label2);
            Controls.Add(timeView);
            Controls.Add(groupGameForm2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Minesweeper";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupGameForm2;
        private Label timeView;
        private Label label2;
        private Button highScore;
        private PictureBox pictureBox1;
        private Button settings;
        private Label home;
    }
}
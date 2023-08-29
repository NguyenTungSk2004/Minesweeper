namespace Minesweeper
{
    partial class Form5
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
            pictureBox1 = new PictureBox();
            Music = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hình_ảnh_chúng_tôi_dơn_giản_là_gấu_cho_Iphone;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, -601);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 855);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Music
            // 
            Music.AutoSize = true;
            Music.BackColor = SystemColors.Info;
            Music.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Music.ForeColor = SystemColors.ActiveCaptionText;
            Music.Location = new Point(139, 137);
            Music.Name = "Music";
            Music.Size = new Size(193, 42);
            Music.TabIndex = 2;
            Music.Text = "Open music";
            Music.TextAlign = ContentAlignment.MiddleCenter;
            Music.TextImageRelation = TextImageRelation.ImageBeforeText;
            Music.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 252);
            Controls.Add(Music);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox Music;
    }
}
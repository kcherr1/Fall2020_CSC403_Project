namespace Fall2020_CSC403_Project
{
    partial class FrmVictory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVictory));
            this.Credits = new System.Windows.Forms.PictureBox();
            this.playAgain_btn = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.credit_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.Transparent;
            this.Credits.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.credit_btn;
            this.Credits.Location = new System.Drawing.Point(-140, 840);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(286, 126);
            this.Credits.TabIndex = 2;
            this.Credits.TabStop = false;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // playAgain_btn
            // 
            this.playAgain_btn.BackColor = System.Drawing.Color.Transparent;
            this.playAgain_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playAgain;
            this.playAgain_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playAgain_btn.Location = new System.Drawing.Point(-12, 300);
            this.playAgain_btn.Name = "playAgain_btn";
            this.playAgain_btn.Size = new System.Drawing.Size(322, 114);
            this.playAgain_btn.TabIndex = 1;
            this.playAgain_btn.TabStop = false;
            this.playAgain_btn.Click += new System.EventHandler(this.playAgain_btn_Click);
            this.playAgain_btn.MouseLeave += new System.EventHandler(this.playAgain_btn_MouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.Location = new System.Drawing.Point(622, 305);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(176, 109);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            this.exit_btn.MouseHover += new System.EventHandler(this.exit_btn_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(348, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 236);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // credit_btn
            // 
            this.credit_btn.BackColor = System.Drawing.Color.Transparent;
            this.credit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.credit_btn;
            this.credit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.credit_btn.Location = new System.Drawing.Point(316, 312);
            this.credit_btn.Name = "credit_btn";
            this.credit_btn.Size = new System.Drawing.Size(254, 102);
            this.credit_btn.TabIndex = 5;
            this.credit_btn.TabStop = false;
            this.credit_btn.MouseLeave += new System.EventHandler(this.credit_btn_MouseLeave);
            this.credit_btn.MouseHover += new System.EventHandler(this.credit_btn_MouseHover);
            // 
            // FrmVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credit_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.playAgain_btn);
            this.Controls.Add(this.exit_btn);
            this.DoubleBuffered = true;
            this.Name = "FrmVictory";
            this.Text = "Victory!";
            this.MouseHover += new System.EventHandler(this.FrmVictory_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.Credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.PictureBox playAgain_btn;
        private System.Windows.Forms.PictureBox Credits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox credit_btn;
    }
}
using System.Drawing;

namespace Fall2020_CSC403_Project
{
    partial class FrmPause
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
            this.resumeGame = new System.Windows.Forms.Button();
            this.quitGame = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // resumeGame
            // 
            this.resumeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeGame.Location = new System.Drawing.Point(502, 230);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(128, 43);
            this.resumeGame.TabIndex = 2;
            this.resumeGame.Text = "Resume";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Click += new System.EventHandler(this.resume_Click);
            // 
            // quitGame
            // 
            this.quitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGame.Location = new System.Drawing.Point(199, 230);
            this.quitGame.Name = "quitGame";
            this.quitGame.Size = new System.Drawing.Size(128, 43);
            this.quitGame.TabIndex = 2;
            this.quitGame.Text = "Quit";
            this.quitGame.UseVisualStyleBackColor = true;
            this.quitGame.Click += new System.EventHandler(this.quit_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(343, 230);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(142, 45);
            this.volumeBar.TabIndex = 7;
            this.volumeBar.TickFrequency = 5;
            this.volumeBar.Value = 20;
            this.volumeBar.Scroll += new System.EventHandler(this.changeMusicVolume);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume";
            // 
            // FrmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanut_victory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitGame);
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.volumeBar);
            this.Name = "FrmPause";
            this.Text = "Pause";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Button quitGame;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label1;
    }
}
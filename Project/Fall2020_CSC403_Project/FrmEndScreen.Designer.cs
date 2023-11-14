namespace Fall2020_CSC403_Project
{
    partial class FrmEndScreen
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
            this.btnLeaveGame = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeaveGame
            // 
            this.btnLeaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveGame.Location = new System.Drawing.Point(411, 346);
            this.btnLeaveGame.Name = "btnLeaveGame";
            this.btnLeaveGame.Size = new System.Drawing.Size(128, 43);
            this.btnLeaveGame.TabIndex = 2;
            this.btnLeaveGame.Text = "Quit";
            this.btnLeaveGame.UseVisualStyleBackColor = true;
            this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.Location = new System.Drawing.Point(237, 346);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(128, 43);
            this.btnRestartGame.TabIndex = 2;
            this.btnRestartGame.Text = "Restart";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // FrmEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gameEndScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeaveGame);
            this.Controls.Add(this.btnRestartGame);
            this.Name = "FrmEndScreen";
            this.Text = "GAME OVER";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox peanut;
        private System.Windows.Forms.Button btnLeaveGame;
        private System.Windows.Forms.Button btnRestartGame;
    }
}
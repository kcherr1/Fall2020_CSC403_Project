namespace Fall2020_CSC403_Project
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.squonkCage = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.squonkCage)).BeginInit();
            this.SuspendLayout();
            // 
            // squonkCage
            // 
            this.squonkCage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squonkCage.BackgroundImage")));
            this.squonkCage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.squonkCage.Location = new System.Drawing.Point(549, 79);
            this.squonkCage.Name = "squonkCage";
            this.squonkCage.Size = new System.Drawing.Size(576, 536);
            this.squonkCage.TabIndex = 0;
            this.squonkCage.TabStop = false;
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(35, 112);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(473, 85);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "Squonk Rescue";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.playBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(152, 269);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(223, 97);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Silver;
            this.quitBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(152, 399);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(223, 95);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Exit Game";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.squonkCage);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.squonkCage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox squonkCage;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}
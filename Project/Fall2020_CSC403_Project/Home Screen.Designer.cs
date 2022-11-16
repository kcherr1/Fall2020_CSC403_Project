namespace Fall2020_CSC403_Project
{
    partial class Home_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Screen));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 131);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(1021, 156);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "\r\n   Welcome to the Gaming Arena.\r\n          Play Hard, Play Well, Success is for" +
    " you !!!";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_PlayButton
            // 
            this.btn_PlayButton.AutoSize = true;
            this.btn_PlayButton.BackColor = System.Drawing.SystemColors.Info;
            this.btn_PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayButton.Location = new System.Drawing.Point(478, 318);
            this.btn_PlayButton.Name = "btn_PlayButton";
            this.btn_PlayButton.Size = new System.Drawing.Size(140, 52);
            this.btn_PlayButton.TabIndex = 1;
            this.btn_PlayButton.Text = "Play";
            this.btn_PlayButton.UseVisualStyleBackColor = false;
            this.btn_PlayButton.Click += new System.EventHandler(this.btn_PlayButton_Click);
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 557);
            this.Controls.Add(this.btn_PlayButton);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Home_Screen";
            this.Text = "Home_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_PlayButton;
    }
}
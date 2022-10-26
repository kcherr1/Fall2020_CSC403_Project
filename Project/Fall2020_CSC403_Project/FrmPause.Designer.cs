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
            this.resumeButton = new System.Windows.Forms.Button();
            this.startOverButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.resumeButton.Font = new System.Drawing.Font("Ravie", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.Location = new System.Drawing.Point(238, 73);
            this.resumeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(687, 151);
            this.resumeButton.TabIndex = 0;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // startOverButton
            // 
            this.startOverButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startOverButton.Font = new System.Drawing.Font("Ravie", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverButton.Location = new System.Drawing.Point(238, 245);
            this.startOverButton.Name = "startOverButton";
            this.startOverButton.Size = new System.Drawing.Size(687, 151);
            this.startOverButton.TabIndex = 1;
            this.startOverButton.Text = "START OVER";
            this.startOverButton.UseVisualStyleBackColor = false;
            this.startOverButton.Click += new System.EventHandler(this.startOverButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.quitButton.Font = new System.Drawing.Font("Ravie", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(238, 416);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(687, 151);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // FrmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pauseMenuBackground;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startOverButton);
            this.Controls.Add(this.resumeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPause";
            this.Text = "Pause Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button startOverButton;
        private System.Windows.Forms.Button quitButton;
    }
}
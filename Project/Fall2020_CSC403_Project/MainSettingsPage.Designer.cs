namespace Fall2020_CSC403_Project
{
    partial class MainSettingsPage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.soundBar = new System.Windows.Forms.TrackBar();
            this.lblSettings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 77);
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Close";
            this.btnClose.Size = new System.Drawing.Size(136, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
           
            // 
            // trackBar1
            // 
            this.soundBar.Location = new System.Drawing.Point(211, 264);
            this.soundBar.Name = "soundBar";
            this.soundBar.Size = new System.Drawing.Size(350, 69);
            this.soundBar.TabIndex = 3;
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblSettings.Location = new System.Drawing.Point(269, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(274, 51);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings Page";
            // 
            // MainSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.soundBar);
            this.Controls.Add(this.btnClose);
            this.Name = "MainSettingsPage";
            this.Text = "MainSettingsPage";
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TrackBar soundBar;
    }
}
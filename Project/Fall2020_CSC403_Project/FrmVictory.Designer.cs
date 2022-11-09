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
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.playAgain_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_btn;
            this.exit_btn.Location = new System.Drawing.Point(608, 318);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(180, 129);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // playAgain_btn
            // 
            this.playAgain_btn.Location = new System.Drawing.Point(25, 342);
            this.playAgain_btn.Name = "playAgain_btn";
            this.playAgain_btn.Size = new System.Drawing.Size(210, 105);
            this.playAgain_btn.TabIndex = 1;
            this.playAgain_btn.TabStop = false;
            this.playAgain_btn.Click += new System.EventHandler(this.playAgain_btn_Click);
            // 
            // FrmVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playAgain_btn);
            this.Controls.Add(this.exit_btn);
            this.Name = "FrmVictory";
            this.Text = "Victory!";
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.PictureBox playAgain_btn;
    }
}
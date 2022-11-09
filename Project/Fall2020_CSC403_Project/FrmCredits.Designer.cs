namespace Fall2020_CSC403_Project
{
    partial class FrmCredits
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
            this.thank_you = new System.Windows.Forms.PictureBox();
            this.scroll_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.thank_you)).BeginInit();
            this.SuspendLayout();
            // 
            // thank_you
            // 
            this.thank_you.Location = new System.Drawing.Point(187, 12);
            this.thank_you.Name = "thank_you";
            this.thank_you.Size = new System.Drawing.Size(393, 155);
            this.thank_you.TabIndex = 0;
            this.thank_you.TabStop = false;
            // 
            // scroll_panel
            // 
            this.scroll_panel.Location = new System.Drawing.Point(152, 185);
            this.scroll_panel.Name = "scroll_panel";
            this.scroll_panel.Size = new System.Drawing.Size(480, 206);
            this.scroll_panel.TabIndex = 1;
            // 
            // FrmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scroll_panel);
            this.Controls.Add(this.thank_you);
            this.Name = "FrmCredits";
            this.Text = "Thank you for playing our game.";
            ((System.ComponentModel.ISupportInitialize)(this.thank_you)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thank_you;
        private System.Windows.Forms.Panel scroll_panel;
    }
}
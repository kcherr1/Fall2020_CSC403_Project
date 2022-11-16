namespace Fall2020_CSC403_Project
{
    partial class FrmDeath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeath));
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.tryAgain_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.Location = new System.Drawing.Point(606, 324);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(198, 114);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            this.exit_btn.MouseHover += new System.EventHandler(this.exit_btn_MouseHover);
            // 
            // tryAgain_btn
            // 
            this.tryAgain_btn.BackColor = System.Drawing.Color.Transparent;
            this.tryAgain_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tryAgain_btn.BackgroundImage")));
            this.tryAgain_btn.Location = new System.Drawing.Point(-36, 310);
            this.tryAgain_btn.Name = "tryAgain_btn";
            this.tryAgain_btn.Size = new System.Drawing.Size(362, 128);
            this.tryAgain_btn.TabIndex = 1;
            this.tryAgain_btn.TabStop = false;
            this.tryAgain_btn.Click += new System.EventHandler(this.tryAgain_btn_Click);
            this.tryAgain_btn.MouseLeave += new System.EventHandler(this.tryAgain_btn_MouseLeave);
            this.tryAgain_btn.MouseHover += new System.EventHandler(this.tryAgain_btn_MouseHover);
            // 
            // FrmDeath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Peanut_Death;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.tryAgain_btn);
            this.DoubleBuffered = true;
            this.Name = "FrmDeath";
            this.Text = "Oh No!";
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox tryAgain_btn;
        private System.Windows.Forms.PictureBox exit_btn;
    }
}
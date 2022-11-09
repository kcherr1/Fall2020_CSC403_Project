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
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.tryAgain_btn = new System.Windows.Forms.PictureBox();
            this.Peanut_death = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peanut_death)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_btn;
            this.exit_btn.Location = new System.Drawing.Point(502, 310);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(226, 114);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // tryAgain_btn
            // 
            this.tryAgain_btn.Location = new System.Drawing.Point(134, 344);
            this.tryAgain_btn.Name = "tryAgain_btn";
            this.tryAgain_btn.Size = new System.Drawing.Size(170, 71);
            this.tryAgain_btn.TabIndex = 1;
            this.tryAgain_btn.TabStop = false;
            // 
            // Peanut_death
            // 
            this.Peanut_death.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Peanut_death.Location = new System.Drawing.Point(222, 119);
            this.Peanut_death.Name = "Peanut_death";
            this.Peanut_death.Size = new System.Drawing.Size(248, 157);
            this.Peanut_death.TabIndex = 0;
            this.Peanut_death.TabStop = false;
            // 
            // FrmDeath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.tryAgain_btn);
            this.Controls.Add(this.Peanut_death);
            this.Name = "FrmDeath";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peanut_death)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Peanut_death;
        private System.Windows.Forms.PictureBox tryAgain_btn;
        private System.Windows.Forms.PictureBox exit_btn;
    }
}
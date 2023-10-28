namespace Fall2020_CSC403_Project
{
    partial class FrmStartMenu
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
            this.btnStartLevel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartLevel
            // 
            this.btnStartLevel.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartLevel.Location = new System.Drawing.Point(288, 152);
            this.btnStartLevel.Name = "btnStartLevel";
            this.btnStartLevel.Size = new System.Drawing.Size(177, 113);
            this.btnStartLevel.TabIndex = 0;
            this.btnStartLevel.Text = "Play";
            this.btnStartLevel.UseVisualStyleBackColor = false;
            this.btnStartLevel.Click += new System.EventHandler(this.btnStartLevel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 305);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(176, 112);
            this.button1.TabIndex = 3;
            this.button1.Text = "Easy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 124);
            this.button2.TabIndex = 4;
            this.button2.Text = "Medium";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 108);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hard";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(966, 826);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartLevel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmStartMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmStartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartLevel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
using System.Runtime.Remoting.Channels;

namespace Fall2020_CSC403_Project
{
    partial class PlayerPicks
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_1;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Location = new System.Drawing.Point(62, 6);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(70, 130);
            this.Button1.TabIndex = 0;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_2;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button2.Location = new System.Drawing.Point(208, 6);
            this.Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(78, 130);
            this.Button2.TabIndex = 1;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_3;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Location = new System.Drawing.Point(355, 7);
            this.Button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(98, 129);
            this.Button3.TabIndex = 2;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_4;
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button4.Location = new System.Drawing.Point(62, 149);
            this.Button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(70, 140);
            this.Button4.TabIndex = 3;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_5;
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button5.Location = new System.Drawing.Point(208, 149);
            this.Button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(78, 140);
            this.Button5.TabIndex = 4;
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.Button6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Player_Choice_6;
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button6.Location = new System.Drawing.Point(355, 149);
            this.Button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(98, 140);
            this.Button6.TabIndex = 5;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PlayerPicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(552, 303);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayerPicks";
            this.Text = "Select Your Avatar!";
            this.Load += new System.EventHandler(this.PlayerPicks_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
    }
}
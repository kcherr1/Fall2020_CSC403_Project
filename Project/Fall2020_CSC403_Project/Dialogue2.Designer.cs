namespace Fall2020_CSC403_Project
{
    partial class Dialogue2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(57, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fall2020_CSC403_Project.Properties.Resources.survivor;
            this.pictureBox2.Location = new System.Drawing.Point(1167, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 285);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 506);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Sshhhh, you have to be quiet or we will both be captured. \r\n";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Crimson;
            this.textBox2.Location = new System.Drawing.Point(1179, 427);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Excuse me sir! Can you help free me?";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 739);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1016, 31);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "That sounds miserable, but luckily I\'m here to save you. When I defeat the Koolai" +
    "d-Man, I will set you free.";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Crimson;
            this.textBox4.Location = new System.Drawing.Point(829, 604);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(732, 59);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "I\'m sorry, I just want to leave this wretched place. The Koolaid-Man is terrible," +
    " and he makes me drink a pitcher of root beer koolaid every day :(\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 174);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Crimson;
            this.textBox5.Location = new System.Drawing.Point(997, 815);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(564, 31);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Thank you so much! He is nearby, so be careful my hero.";
            // 
            // Dialogue2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1631, 904);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dialogue2";
            this.Text = "Survivor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
    }
}
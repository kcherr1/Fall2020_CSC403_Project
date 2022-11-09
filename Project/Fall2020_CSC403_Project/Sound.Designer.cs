namespace Fall2020_CSC403_Project
{
    partial class Sound
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_btn = new System.Windows.Forms.PictureBox();
            this.Volume_val = new System.Windows.Forms.Label();
            this.Volume_slider = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Sound_btn;
            this.pictureBox1.Location = new System.Drawing.Point(283, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.Volume_val);
            this.panel1.Controls.Add(this.Volume_slider);
            this.panel1.Controls.Add(this.Volume);
            this.panel1.Location = new System.Drawing.Point(183, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 274);
            this.panel1.TabIndex = 1;
            // 
            // Back_btn
            // 
            this.Back_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Back_btn;
            this.Back_btn.Location = new System.Drawing.Point(119, 146);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(238, 127);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.TabStop = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Volume_val
            // 
            this.Volume_val.AutoSize = true;
            this.Volume_val.Font = new System.Drawing.Font("Forte", 21.75F);
            this.Volume_val.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Volume_val.Location = new System.Drawing.Point(367, 74);
            this.Volume_val.Name = "Volume_val";
            this.Volume_val.Size = new System.Drawing.Size(29, 32);
            this.Volume_val.TabIndex = 2;
            this.Volume_val.Text = "0";
            // 
            // Volume_slider
            // 
            this.Volume_slider.BackColor = System.Drawing.SystemColors.MenuText;
            this.Volume_slider.Location = new System.Drawing.Point(143, 74);
            this.Volume_slider.Maximum = 100;
            this.Volume_slider.Name = "Volume_slider";
            this.Volume_slider.Size = new System.Drawing.Size(218, 45);
            this.Volume_slider.TabIndex = 1;
            this.Volume_slider.ValueChanged += new System.EventHandler(this.Volume_slider_ValueChanged);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.Color.Peru;
            this.Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Volume.Font = new System.Drawing.Font("Forte", 21.75F);
            this.Volume.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Volume.Location = new System.Drawing.Point(27, 72);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(110, 34);
            this.Volume.TabIndex = 0;
            this.Volume.Text = "Volume";
            // 
            // Sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sound";
            this.Text = "Sound";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.PictureBox Back_btn;
        private System.Windows.Forms.Label Volume_val;
        private System.Windows.Forms.TrackBar Volume_slider;
    }
}
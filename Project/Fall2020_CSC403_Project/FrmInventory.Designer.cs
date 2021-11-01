namespace Fall2020_CSC403_Project
{
    partial class FrmInventory
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
            this.Equip = new System.Windows.Forms.Button();
            this.getHealth = new System.Windows.Forms.PictureBox();
            this.getIntelligence = new System.Windows.Forms.PictureBox();
            this.getPower = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.getHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPower)).BeginInit();
            this.SuspendLayout();
            // 
            // Equip
            // 
            this.Equip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Equip.ForeColor = System.Drawing.Color.Red;
            this.Equip.Location = new System.Drawing.Point(475, 598);
            this.Equip.Name = "Equip";
            this.Equip.Size = new System.Drawing.Size(245, 91);
            this.Equip.TabIndex = 0;
            this.Equip.Text = "Equip";
            this.Equip.UseVisualStyleBackColor = false;
            this.Equip.Click += new System.EventHandler(this.button1_Click);
            // 
            // getHealth
            // 
            this.getHealth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getHealth.Location = new System.Drawing.Point(141, 104);
            this.getHealth.Name = "getHealth";
            this.getHealth.Size = new System.Drawing.Size(181, 157);
            this.getHealth.TabIndex = 1;
            this.getHealth.TabStop = false;
            this.getHealth.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // getIntelligence
            // 
            this.getIntelligence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getIntelligence.Location = new System.Drawing.Point(896, 104);
            this.getIntelligence.Name = "getIntelligence";
            this.getIntelligence.Size = new System.Drawing.Size(181, 157);
            this.getIntelligence.TabIndex = 2;
            this.getIntelligence.TabStop = false;
            this.getIntelligence.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // getPower
            // 
            this.getPower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getPower.Location = new System.Drawing.Point(501, 104);
            this.getPower.Name = "getPower";
            this.getPower.Size = new System.Drawing.Size(181, 157);
            this.getPower.TabIndex = 3;
            this.getPower.TabStop = false;
            this.getPower.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(919, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Intelligence";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Power";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Health";
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1203, 737);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getPower);
            this.Controls.Add(this.getIntelligence);
            this.Controls.Add(this.getHealth);
            this.Controls.Add(this.Equip);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.getHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Equip;
        private System.Windows.Forms.PictureBox getHealth;
        private System.Windows.Forms.PictureBox getIntelligence;
        private System.Windows.Forms.PictureBox getPower;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
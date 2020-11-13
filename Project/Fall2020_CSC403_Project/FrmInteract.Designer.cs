namespace Fall2020_CSC403_Project
{
    partial class FrmInteract
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
            this.btnInteract1 = new System.Windows.Forms.Button();
            this.btnInteract2 = new System.Windows.Forms.Button();
            this.lblInteract = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.babypeanut;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(581, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 122);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnInteract1
            // 
            this.btnInteract1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteract1.Location = new System.Drawing.Point(185, 105);
            this.btnInteract1.Name = "btnInteract1";
            this.btnInteract1.Size = new System.Drawing.Size(107, 52);
            this.btnInteract1.TabIndex = 2;
            this.btnInteract1.Text = "Collect Child";
            this.btnInteract1.UseVisualStyleBackColor = true;
            this.btnInteract1.Click += new System.EventHandler(this.btnInteract1_Click);
            // 
            // btnInteract2
            // 
            this.btnInteract2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteract2.Location = new System.Drawing.Point(387, 105);
            this.btnInteract2.Name = "btnInteract2";
            this.btnInteract2.Size = new System.Drawing.Size(107, 52);
            this.btnInteract2.TabIndex = 3;
            this.btnInteract2.Text = "Banish him!";
            this.btnInteract2.UseVisualStyleBackColor = true;
            this.btnInteract2.Click += new System.EventHandler(this.btnInteract2_Click);
            // 
            // lblInteract
            // 
            this.lblInteract.AutoSize = true;
            this.lblInteract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteract.Location = new System.Drawing.Point(201, 49);
            this.lblInteract.Name = "lblInteract";
            this.lblInteract.Size = new System.Drawing.Size(419, 20);
            this.lblInteract.TabIndex = 4;
            this.lblInteract.Text = "Mr.Peanut has found his lost nut, what shall he do?";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(285, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Leave Interaction.";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInteract);
            this.Controls.Add(this.btnInteract2);
            this.Controls.Add(this.btnInteract1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInteract";
            this.Text = "FrmInteract";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInteract1;
        private System.Windows.Forms.Button btnInteract2;
        private System.Windows.Forms.Label lblInteract;
        private System.Windows.Forms.Button btnExit;
    }
}
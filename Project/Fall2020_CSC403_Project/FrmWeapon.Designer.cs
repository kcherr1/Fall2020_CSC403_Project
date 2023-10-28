namespace Fall2020_CSC403_Project
{
    partial class FrmWeapon
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
            this.picHand = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picGun = new System.Windows.Forms.PictureBox();
            this.picBomb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // picHand
            // 
            this.picHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHand.Image = global::Fall2020_CSC403_Project.Properties.Resources.hand;
            this.picHand.Location = new System.Drawing.Point(52, 69);
            this.picHand.Name = "picHand";
            this.picHand.Size = new System.Drawing.Size(128, 73);
            this.picHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHand.TabIndex = 0;
            this.picHand.TabStop = false;
            this.picHand.Click += new System.EventHandler(this.picHand_Click);
            // 
            // picSword
            // 
            this.picSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSword.Image = global::Fall2020_CSC403_Project.Properties.Resources.sword;
            this.picSword.Location = new System.Drawing.Point(227, 69);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(128, 73);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 1;
            this.picSword.TabStop = false;
            this.picSword.Click += new System.EventHandler(this.picSword_Click);
            // 
            // picGun
            // 
            this.picGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGun.Image = global::Fall2020_CSC403_Project.Properties.Resources.weapon;
            this.picGun.Location = new System.Drawing.Point(431, 69);
            this.picGun.Name = "picGun";
            this.picGun.Size = new System.Drawing.Size(128, 73);
            this.picGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGun.TabIndex = 2;
            this.picGun.TabStop = false;
            this.picGun.Click += new System.EventHandler(this.picGun_Click);
            // 
            // picBomb
            // 
            this.picBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBomb.Image = global::Fall2020_CSC403_Project.Properties.Resources.bomb;
            this.picBomb.Location = new System.Drawing.Point(645, 69);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(128, 73);
            this.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomb.TabIndex = 3;
            this.picBomb.TabStop = false;
            this.picBomb.Click += new System.EventHandler(this.picBomb_Click);
            // 
            // FrmWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 207);
            this.Controls.Add(this.picBomb);
            this.Controls.Add(this.picGun);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picHand);
            this.Name = "FrmWeapon";
            this.Text = "Chose Your Weapon";
            this.Load += new System.EventHandler(this.FrmWeapon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHand;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picGun;
        private System.Windows.Forms.PictureBox picBomb;
    }
}
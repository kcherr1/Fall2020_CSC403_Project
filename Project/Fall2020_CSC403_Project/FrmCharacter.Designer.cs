namespace Fall2020_CSC403_Project
{
    partial class FrmCharacter
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
            this.lbl_Character = new System.Windows.Forms.Label();
            this.picFlyingTurtle = new System.Windows.Forms.PictureBox();
            this.picTurtle = new System.Windows.Forms.PictureBox();
            this.picTechna = new System.Windows.Forms.PictureBox();
            this.picMrPeanut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFlyingTurtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMrPeanut)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Character
            // 
            this.lbl_Character.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Character.AutoSize = true;
            this.lbl_Character.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Character.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Character.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_Character.Location = new System.Drawing.Point(231, 55);
            this.lbl_Character.Name = "lbl_Character";
            this.lbl_Character.Size = new System.Drawing.Size(335, 49);
            this.lbl_Character.TabIndex = 4;
            this.lbl_Character.Text = "Choose Character";
            this.lbl_Character.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFlyingTurtle
            // 
            this.picFlyingTurtle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFlyingTurtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFlyingTurtle.Image = global::Fall2020_CSC403_Project.Properties.Resources.flying_turtle;
            this.picFlyingTurtle.Location = new System.Drawing.Point(96, 150);
            this.picFlyingTurtle.Name = "picFlyingTurtle";
            this.picFlyingTurtle.Size = new System.Drawing.Size(111, 149);
            this.picFlyingTurtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlyingTurtle.TabIndex = 5;
            this.picFlyingTurtle.TabStop = false;
            this.picFlyingTurtle.Click += new System.EventHandler(this.picFlyingTurtle_Click);
            // 
            // picTurtle
            // 
            this.picTurtle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTurtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTurtle.Image = global::Fall2020_CSC403_Project.Properties.Resources.turtle;
            this.picTurtle.Location = new System.Drawing.Point(262, 151);
            this.picTurtle.Name = "picTurtle";
            this.picTurtle.Size = new System.Drawing.Size(111, 149);
            this.picTurtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurtle.TabIndex = 9;
            this.picTurtle.TabStop = false;
            this.picTurtle.Click += new System.EventHandler(this.picTurtle_Click);
            // 
            // picTechna
            // 
            this.picTechna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTechna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTechna.Image = global::Fall2020_CSC403_Project.Properties.Resources.tecna;
            this.picTechna.Location = new System.Drawing.Point(429, 151);
            this.picTechna.Name = "picTechna";
            this.picTechna.Size = new System.Drawing.Size(111, 149);
            this.picTechna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTechna.TabIndex = 10;
            this.picTechna.TabStop = false;
            this.picTechna.Click += new System.EventHandler(this.picTechna_Click);
            // 
            // picMrPeanut
            // 
            this.picMrPeanut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMrPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMrPeanut.Image = global::Fall2020_CSC403_Project.Properties.Resources.mr_peanut;
            this.picMrPeanut.InitialImage = null;
            this.picMrPeanut.Location = new System.Drawing.Point(591, 151);
            this.picMrPeanut.Name = "picMrPeanut";
            this.picMrPeanut.Size = new System.Drawing.Size(111, 149);
            this.picMrPeanut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMrPeanut.TabIndex = 11;
            this.picMrPeanut.TabStop = false;
            this.picMrPeanut.Click += new System.EventHandler(this.picMrPeanut_Click);
            // 
            // FrmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.character;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMrPeanut);
            this.Controls.Add(this.picTechna);
            this.Controls.Add(this.picTurtle);
            this.Controls.Add(this.picFlyingTurtle);
            this.Controls.Add(this.lbl_Character);
            this.DoubleBuffered = true;
            this.Name = "FrmCharacter";
            this.Text = "FrmCharacter";
            this.Load += new System.EventHandler(this.FrmCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFlyingTurtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMrPeanut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Character;
        private System.Windows.Forms.PictureBox picFlyingTurtle;
        private System.Windows.Forms.PictureBox picTurtle;
        private System.Windows.Forms.PictureBox picTechna;
        private System.Windows.Forms.PictureBox picMrPeanut;
    }
}
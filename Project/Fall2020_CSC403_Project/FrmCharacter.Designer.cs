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
            this.choose_Your_Character = new System.Windows.Forms.PictureBox();
            this.Honey_peanut = new System.Windows.Forms.PictureBox();
            this.Salty_peanut = new System.Windows.Forms.PictureBox();
            this.Crunchy_peanut = new System.Windows.Forms.PictureBox();
            this.orginial_peanut = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.choose_Your_Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Honey_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salty_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crunchy_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginial_peanut)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose_Your_Character
            // 
            this.choose_Your_Character.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Choose_character;
            this.choose_Your_Character.Location = new System.Drawing.Point(70, 12);
            this.choose_Your_Character.Name = "choose_Your_Character";
            this.choose_Your_Character.Size = new System.Drawing.Size(748, 130);
            this.choose_Your_Character.TabIndex = 4;
            this.choose_Your_Character.TabStop = false;
            // 
            // Honey_peanut
            // 
            this.Honey_peanut.BackColor = System.Drawing.Color.Peru;
            this.Honey_peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.honey_peanut;
            this.Honey_peanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Honey_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Honey_peanut.Location = new System.Drawing.Point(540, 12);
            this.Honey_peanut.Name = "Honey_peanut";
            this.Honey_peanut.Size = new System.Drawing.Size(125, 236);
            this.Honey_peanut.TabIndex = 3;
            this.Honey_peanut.TabStop = false;
            this.Honey_peanut.Click += new System.EventHandler(this.Honey_peanut_Click);
            // 
            // Salty_peanut
            // 
            this.Salty_peanut.BackColor = System.Drawing.Color.Peru;
            this.Salty_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Salty_peanut.Location = new System.Drawing.Point(202, 12);
            this.Salty_peanut.Name = "Salty_peanut";
            this.Salty_peanut.Size = new System.Drawing.Size(123, 236);
            this.Salty_peanut.TabIndex = 2;
            this.Salty_peanut.TabStop = false;
            // 
            // Crunchy_peanut
            // 
            this.Crunchy_peanut.BackColor = System.Drawing.Color.Peru;
            this.Crunchy_peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Crunchy_peanut;
            this.Crunchy_peanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crunchy_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crunchy_peanut.Location = new System.Drawing.Point(376, 12);
            this.Crunchy_peanut.Name = "Crunchy_peanut";
            this.Crunchy_peanut.Size = new System.Drawing.Size(123, 236);
            this.Crunchy_peanut.TabIndex = 1;
            this.Crunchy_peanut.TabStop = false;
            this.Crunchy_peanut.Click += new System.EventHandler(this.Crunchy_peanut_Click);
            // 
            // orginial_peanut
            // 
            this.orginial_peanut.BackColor = System.Drawing.Color.Peru;
            this.orginial_peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.orginial_peanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orginial_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orginial_peanut.Location = new System.Drawing.Point(19, 12);
            this.orginial_peanut.Name = "orginial_peanut";
            this.orginial_peanut.Size = new System.Drawing.Size(123, 236);
            this.orginial_peanut.TabIndex = 0;
            this.orginial_peanut.TabStop = false;
            this.orginial_peanut.Click += new System.EventHandler(this.orginial_peanut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.Honey_peanut);
            this.panel1.Controls.Add(this.orginial_peanut);
            this.panel1.Controls.Add(this.Salty_peanut);
            this.panel1.Controls.Add(this.Crunchy_peanut);
            this.panel1.Location = new System.Drawing.Point(95, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 253);
            this.panel1.TabIndex = 5;
            // 
            // FrmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.choose_Your_Character);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmCharacter";
            this.Text = "Choose your Character";
            ((System.ComponentModel.ISupportInitialize)(this.choose_Your_Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Honey_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salty_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crunchy_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginial_peanut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orginial_peanut;
        private System.Windows.Forms.PictureBox Crunchy_peanut;
        private System.Windows.Forms.PictureBox Salty_peanut;
        private System.Windows.Forms.PictureBox Honey_peanut;
        private System.Windows.Forms.PictureBox choose_Your_Character;
        private System.Windows.Forms.Panel panel1;
    }
}
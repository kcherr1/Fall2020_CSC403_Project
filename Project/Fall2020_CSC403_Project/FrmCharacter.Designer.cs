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
            ((System.ComponentModel.ISupportInitialize)(this.choose_Your_Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Honey_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salty_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crunchy_peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginial_peanut)).BeginInit();
            this.SuspendLayout();
            // 
            // choose_Your_Character
            // 
            this.choose_Your_Character.Location = new System.Drawing.Point(171, 15);
            this.choose_Your_Character.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choose_Your_Character.Name = "choose_Your_Character";
            this.choose_Your_Character.Size = new System.Drawing.Size(763, 130);
            this.choose_Your_Character.TabIndex = 4;
            this.choose_Your_Character.TabStop = false;
            // 
            // Honey_peanut
            // 
            this.Honey_peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.honey_peanut;
            this.Honey_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Honey_peanut.Location = new System.Drawing.Point(880, 209);
            this.Honey_peanut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Honey_peanut.Name = "Honey_peanut";
            this.Honey_peanut.Size = new System.Drawing.Size(145, 288);
            this.Honey_peanut.TabIndex = 3;
            this.Honey_peanut.TabStop = false;
            // 
            // Salty_peanut
            // 
            this.Salty_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Salty_peanut.Location = new System.Drawing.Point(359, 209);
            this.Salty_peanut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salty_peanut.Name = "Salty_peanut";
            this.Salty_peanut.Size = new System.Drawing.Size(145, 288);
            this.Salty_peanut.TabIndex = 2;
            this.Salty_peanut.TabStop = false;
            // 
            // Crunchy_peanut
            // 
            this.Crunchy_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crunchy_peanut.Location = new System.Drawing.Point(625, 207);
            this.Crunchy_peanut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Crunchy_peanut.Name = "Crunchy_peanut";
            this.Crunchy_peanut.Size = new System.Drawing.Size(145, 288);
            this.Crunchy_peanut.TabIndex = 1;
            this.Crunchy_peanut.TabStop = false;
            // 
            // orginial_peanut
            // 
            this.orginial_peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.orginial_peanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orginial_peanut.Location = new System.Drawing.Point(127, 209);
            this.orginial_peanut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orginial_peanut.Name = "orginial_peanut";
            this.orginial_peanut.Size = new System.Drawing.Size(141, 290);
            this.orginial_peanut.TabIndex = 0;
            this.orginial_peanut.TabStop = false;
            this.orginial_peanut.Click += new System.EventHandler(this.orginial_peanut_Click);
            // 
            // FrmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 583);
            this.Controls.Add(this.choose_Your_Character);
            this.Controls.Add(this.Honey_peanut);
            this.Controls.Add(this.Salty_peanut);
            this.Controls.Add(this.Crunchy_peanut);
            this.Controls.Add(this.orginial_peanut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCharacter";
            this.Text = "Choose your Character";
            ((System.ComponentModel.ISupportInitialize)(this.choose_Your_Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Honey_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salty_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crunchy_peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginial_peanut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orginial_peanut;
        private System.Windows.Forms.PictureBox Crunchy_peanut;
        private System.Windows.Forms.PictureBox Salty_peanut;
        private System.Windows.Forms.PictureBox Honey_peanut;
        private System.Windows.Forms.PictureBox choose_Your_Character;
    }
}
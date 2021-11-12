
namespace Fall2020_CSC403_Project
{
    partial class FrmGameOver
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
            this.buttonQuitGame = new System.Windows.Forms.Button();
            this.buttonReturnMainMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuitGame
            // 
            this.buttonQuitGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitGame.ForeColor = System.Drawing.Color.Red;
            this.buttonQuitGame.Location = new System.Drawing.Point(548, 622);
            this.buttonQuitGame.Name = "buttonQuitGame";
            this.buttonQuitGame.Size = new System.Drawing.Size(325, 70);
            this.buttonQuitGame.TabIndex = 1;
            this.buttonQuitGame.Text = "Quit Game";
            this.buttonQuitGame.UseVisualStyleBackColor = true;
            this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
            // 
            // buttonReturnMainMenu
            // 
            this.buttonReturnMainMenu.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMainMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonReturnMainMenu.Location = new System.Drawing.Point(214, 622);
            this.buttonReturnMainMenu.Name = "buttonReturnMainMenu";
            this.buttonReturnMainMenu.Size = new System.Drawing.Size(325, 70);
            this.buttonReturnMainMenu.TabIndex = 3;
            this.buttonReturnMainMenu.Text = "Return to Main Menu";
            this.buttonReturnMainMenu.UseVisualStyleBackColor = true;
            this.buttonReturnMainMenu.Click += new System.EventHandler(this.buttonReturnMainMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fall2020_CSC403_Project.Properties.Resources.youdied;
            this.pictureBox2.Location = new System.Drawing.Point(214, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(659, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.death;
            this.pictureBox1.Location = new System.Drawing.Point(298, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1110, 743);
            this.Controls.Add(this.buttonReturnMainMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonQuitGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQuitGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonReturnMainMenu;
    }
}
using System.Threading;

namespace Fall2020_CSC403_Project
{
    partial class FrmWinScreen
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
            this.btnLeaveGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.peanut_victory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.peanut_victory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeaveGame
            // 
            this.btnLeaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveGame.Location = new System.Drawing.Point(339, 354);
            this.btnLeaveGame.Name = "btnLeaveGame";
            this.btnLeaveGame.Size = new System.Drawing.Size(128, 43);
            this.btnLeaveGame.TabIndex = 2;
            this.btnLeaveGame.Text = "Quit";
            this.btnLeaveGame.UseVisualStyleBackColor = true;
            this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(283, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 54);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "VICTORY";
            // 
            // peanut_victory
            // 
            this.peanut_victory.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanut_victory;
            this.peanut_victory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.peanut_victory.Location = new System.Drawing.Point(281, 79);
            this.peanut_victory.Name = "peanut_victory";
            this.peanut_victory.Size = new System.Drawing.Size(234, 256);
            this.peanut_victory.TabIndex = 0;
            this.peanut_victory.TabStop = false;
            // 
            // FrmWinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLeaveGame);
            this.Controls.Add(this.peanut_victory);
            this.Name = "FrmWinScreen";
            this.Text = "VICTORY";
            ((System.ComponentModel.ISupportInitialize)(this.peanut_victory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox peanut_victory;
        private System.Windows.Forms.Button btnLeaveGame;
    }
}
namespace Fall2020_CSC403_Project
{
    partial class FrmStart
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lbl_Character = new System.Windows.Forms.Label();
            this.lblExitGame = new System.Windows.Forms.Label();
            this.picResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitle.Location = new System.Drawing.Point(0, -12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(960, 79);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Super Fighter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewGame
            // 
            this.lblNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lblNewGame.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGame.ForeColor = System.Drawing.Color.Aqua;
            this.lblNewGame.Location = new System.Drawing.Point(361, 68);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(215, 49);
            this.lblNewGame.TabIndex = 2;
            this.lblNewGame.Text = "New Game";
            this.lblNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            this.lblNewGame.MouseLeave += new System.EventHandler(this.lblNewGame_Leave);
            this.lblNewGame.MouseHover += new System.EventHandler(this.lblNewGame_Hover);
            // 
            // lbl_Character
            // 
            this.lbl_Character.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Character.AutoSize = true;
            this.lbl_Character.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Character.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Character.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_Character.Location = new System.Drawing.Point(316, 142);
            this.lbl_Character.Name = "lbl_Character";
            this.lbl_Character.Size = new System.Drawing.Size(335, 49);
            this.lbl_Character.TabIndex = 3;
            this.lbl_Character.Text = "Choose Character";
            this.lbl_Character.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Character.Click += new System.EventHandler(this.lbl_Character_Click);
            this.lbl_Character.MouseLeave += new System.EventHandler(this.lbl_Character_Leave);
            this.lbl_Character.MouseHover += new System.EventHandler(this.lbl_Character_Hover);
            // 
            // lblExitGame
            // 
            this.lblExitGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExitGame.AutoSize = true;
            this.lblExitGame.BackColor = System.Drawing.Color.Transparent;
            this.lblExitGame.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitGame.ForeColor = System.Drawing.Color.Aqua;
            this.lblExitGame.Location = new System.Drawing.Point(365, 216);
            this.lblExitGame.Name = "lblExitGame";
            this.lblExitGame.Size = new System.Drawing.Size(211, 49);
            this.lblExitGame.TabIndex = 4;
            this.lblExitGame.Text = "Exit Game";
            this.lblExitGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExitGame.Click += new System.EventHandler(this.lblExitGame_Click);
            this.lblExitGame.MouseLeave += new System.EventHandler(this.lblExitGame_Leave);
            this.lblExitGame.MouseHover += new System.EventHandler(this.lblExitGame_Hover);
            // 
            // picResult
            // 
            this.picResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResult.Location = new System.Drawing.Point(409, 292);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(119, 68);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 5;
            this.picResult.TabStop = false;
            this.picResult.Visible = false;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.super;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(960, 543);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.lblExitGame);
            this.Controls.Add(this.lbl_Character);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
            this.Load += new System.EventHandler(this.FrmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lbl_Character;
        private System.Windows.Forms.Label lblExitGame;
        private System.Windows.Forms.PictureBox picResult;
    }
}
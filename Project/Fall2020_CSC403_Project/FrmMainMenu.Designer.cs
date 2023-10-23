
namespace Fall2020_CSC403_Project
{
    partial class FrmMainMenu
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnLeaveGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.peanut = new System.Windows.Forms.PictureBox();
            this.koolaid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.peanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolaid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(338, 254);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(128, 43);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnLeaveGame
            // 
            this.btnLeaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveGame.Location = new System.Drawing.Point(338, 342);
            this.btnLeaveGame.Name = "btnLeaveGame";
            this.btnLeaveGame.Size = new System.Drawing.Size(128, 43);
            this.btnLeaveGame.TabIndex = 2;
            this.btnLeaveGame.Text = "Quit";
            this.btnLeaveGame.UseVisualStyleBackColor = true;
            this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Blue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(172, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 54);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Kool-Aid Krushers";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // peanut
            // 
            this.peanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.peanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.peanut.Location = new System.Drawing.Point(75, 166);
            this.peanut.Name = "peanut";
            this.peanut.Size = new System.Drawing.Size(178, 205);
            this.peanut.TabIndex = 0;
            this.peanut.TabStop = false;
            // 
            // koolaid
            // 
            this.koolaid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.koolaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.koolaid.Location = new System.Drawing.Point(519, 130);
            this.koolaid.Name = "koolaid";
            this.koolaid.Size = new System.Drawing.Size(229, 267);
            this.koolaid.TabIndex = 1;
            this.koolaid.TabStop = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnLeaveGame);
            this.Controls.Add(this.peanut);
            this.Controls.Add(this.koolaid);
            this.Name = "FrmMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.peanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox peanut;
        private System.Windows.Forms.PictureBox koolaid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnLeaveGame;
    }
}
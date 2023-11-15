﻿using System;

namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.GameOverText = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BlackSquare = new System.Windows.Forms.PictureBox();
            this.InvPicButton = new System.Windows.Forms.PictureBox();
            this.MainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvPicButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(18, 14);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(79, 29);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.BackColor = System.Drawing.Color.Black;
            this.GameOverText.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverText.ForeColor = System.Drawing.Color.Red;
            this.GameOverText.Location = new System.Drawing.Point(321, 109);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(680, 160);
            this.GameOverText.TabIndex = 21;
            this.GameOverText.Text = "You Died";
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverText.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.DarkGray;
            this.RestartButton.Enabled = false;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(495, 899);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(100, 30);
            this.RestartButton.TabIndex = 22;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkGray;
            this.ExitButton.Enabled = false;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(645, 901);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 30);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BlackSquare
            // 
            this.BlackSquare.Image = global::Fall2020_CSC403_Project.Properties.Resources.tile_void;
            this.BlackSquare.Location = new System.Drawing.Point(1002, 86);
            this.BlackSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BlackSquare.Name = "BlackSquare";
            this.BlackSquare.Size = new System.Drawing.Size(112, 62);
            this.BlackSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlackSquare.TabIndex = 25;
            this.BlackSquare.TabStop = false;
            this.BlackSquare.Visible = false;
            // 
            // InvPicButton
            // 
            this.InvPicButton.Image = global::Fall2020_CSC403_Project.Properties.Resources.InvButton;
            this.InvPicButton.Location = new System.Drawing.Point(14, 64);
            this.InvPicButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InvPicButton.Name = "InvPicButton";
            this.InvPicButton.Size = new System.Drawing.Size(110, 146);
            this.InvPicButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InvPicButton.TabIndex = 26;
            this.InvPicButton.TabStop = false;
            this.InvPicButton.Click += new System.EventHandler(this.Menu_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.DarkGray;
            this.MainMenuButton.Enabled = false;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Location = new System.Drawing.Point(554, 836);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(100, 30);
            this.MainMenuButton.TabIndex = 27;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Visible = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1569, 1050);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.InvPicButton);
            this.Controls.Add(this.BlackSquare);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GameOverText);
            this.Controls.Add(this.lblInGameTime);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BlackSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvPicButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Label GameOverText;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox BlackSquare;
        private System.Windows.Forms.PictureBox InvPicButton;
        private System.Windows.Forms.Button MainMenuButton;
    }
}


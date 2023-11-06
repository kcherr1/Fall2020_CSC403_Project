﻿namespace Fall2020_CSC403_Project
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.playBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelHome = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(385, 290);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(207, 58);
            this.playBtn.TabIndex = 0;
            this.playBtn.TabStop = false;
            this.playBtn.Text = "New Game";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(385, 363);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(207, 58);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(12, 9);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(418, 101);
            this.labelHome.TabIndex = 4;
            this.labelHome.Text = "Welcome!";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Gray;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.labelMenu.Location = new System.Drawing.Point(361, 182);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Padding = new System.Windows.Forms.Padding(15, 5, 10, 0);
            this.labelMenu.Size = new System.Drawing.Size(236, 81);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "MENU";
            // 
            // FrmHome
            // 
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyDown);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 547);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playBtn);
            this.KeyPreview = true;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelMenu;
    }
}
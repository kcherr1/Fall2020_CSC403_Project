﻿namespace Fall2020_CSC403_Project
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Options_panel = new System.Windows.Forms.Panel();
            this.Sound_btn = new System.Windows.Forms.PictureBox();
            this.Back_btn1 = new System.Windows.Forms.PictureBox();
            this.Difficulty_btn = new System.Windows.Forms.PictureBox();
            this.new_game_btn = new System.Windows.Forms.PictureBox();
            this.Save_btn = new System.Windows.Forms.PictureBox();
            this.Options_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.credits_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Options_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sound_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_game_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Options_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Options_panel);
            this.panel1.Controls.Add(this.new_game_btn);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.Options_btn);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Location = new System.Drawing.Point(53, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 681);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Game_Title;
            this.pictureBox1.Location = new System.Drawing.Point(-57, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 194);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Options_panel
            // 
            this.Options_panel.Controls.Add(this.Sound_btn);
            this.Options_panel.Controls.Add(this.Back_btn1);
            this.Options_panel.Controls.Add(this.Difficulty_btn);
            this.Options_panel.Controls.Add(this.credits_btn);
            this.Options_panel.Location = new System.Drawing.Point(205, 198);
            this.Options_panel.Name = "Options_panel";
            this.Options_panel.Size = new System.Drawing.Size(634, 483);
            this.Options_panel.TabIndex = 4;
            this.Options_panel.Visible = false;
            // 
            // Sound_btn
            // 
            this.Sound_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Sound_btn;
            this.Sound_btn.Location = new System.Drawing.Point(180, 134);
            this.Sound_btn.Name = "Sound_btn";
            this.Sound_btn.Size = new System.Drawing.Size(283, 122);
            this.Sound_btn.TabIndex = 2;
            this.Sound_btn.TabStop = false;
            this.Sound_btn.Visible = false;
            this.Sound_btn.Click += new System.EventHandler(this.Sound_btn_Click);
            this.Sound_btn.MouseLeave += new System.EventHandler(this.Sound_btn_MouseLeave);
            this.Sound_btn.MouseHover += new System.EventHandler(this.Sound_btn_MouseHover);
            // 
            // Back_btn1
            // 
            this.Back_btn1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Back_btn;
            this.Back_btn1.Location = new System.Drawing.Point(194, 343);
            this.Back_btn1.Name = "Back_btn1";
            this.Back_btn1.Size = new System.Drawing.Size(248, 126);
            this.Back_btn1.TabIndex = 1;
            this.Back_btn1.TabStop = false;
            this.Back_btn1.Visible = false;
            this.Back_btn1.Click += new System.EventHandler(this.Back_btn1_Click);
            this.Back_btn1.MouseLeave += new System.EventHandler(this.Back_btn1_MouseLeave);
            this.Back_btn1.MouseHover += new System.EventHandler(this.Back_btn1_MouseHover);
            // 
            // Difficulty_btn
            // 
            this.Difficulty_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Difficulty_btn.BackgroundImage")));
            this.Difficulty_btn.Location = new System.Drawing.Point(140, 4);
            this.Difficulty_btn.Name = "Difficulty_btn";
            this.Difficulty_btn.Size = new System.Drawing.Size(342, 126);
            this.Difficulty_btn.TabIndex = 0;
            this.Difficulty_btn.TabStop = false;
            this.Difficulty_btn.Visible = false;
            this.Difficulty_btn.Click += new System.EventHandler(this.Difficulty_btn_Click);
            this.Difficulty_btn.MouseLeave += new System.EventHandler(this.Difficulty_btn_MouseLeave);
            this.Difficulty_btn.MouseHover += new System.EventHandler(this.Difficulty_btn_MouseHover);
            // 
            // new_game_btn
            // 
            this.new_game_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.new_game_btn;
            this.new_game_btn.Location = new System.Drawing.Point(349, 203);
            this.new_game_btn.Name = "new_game_btn";
            this.new_game_btn.Size = new System.Drawing.Size(363, 133);
            this.new_game_btn.TabIndex = 0;
            this.new_game_btn.TabStop = false;
            this.new_game_btn.Click += new System.EventHandler(this.new_game_btn_Click);
            this.new_game_btn.MouseLeave += new System.EventHandler(this.new_game_btn_MouseLeave);
            this.new_game_btn.MouseHover += new System.EventHandler(this.new_game_btn_MouseHover);
            // 
            // Save_btn
            // 
            this.Save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_btn.BackgroundImage")));
            this.Save_btn.Location = new System.Drawing.Point(399, 316);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(254, 127);
            this.Save_btn.TabIndex = 1;
            this.Save_btn.TabStop = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            this.Save_btn.MouseLeave += new System.EventHandler(this.Save_btn_MouseLeave);
            this.Save_btn.MouseHover += new System.EventHandler(this.Load_btn_MouseHover);
            // 
            // Options_btn
            // 
            this.Options_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Options_btn.BackgroundImage")));
            this.Options_btn.Location = new System.Drawing.Point(372, 407);
            this.Options_btn.Name = "Options_btn";
            this.Options_btn.Size = new System.Drawing.Size(304, 141);
            this.Options_btn.TabIndex = 2;
            this.Options_btn.TabStop = false;
            this.Options_btn.Click += new System.EventHandler(this.Options_btn_Click);
            this.Options_btn.MouseLeave += new System.EventHandler(this.Options_btn_MouseLeave);
            this.Options_btn.MouseHover += new System.EventHandler(this.Options_btn_MouseHover);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_btn.BackgroundImage")));
            this.Exit_btn.Location = new System.Drawing.Point(412, 507);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(241, 125);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            this.Exit_btn.MouseLeave += new System.EventHandler(this.Exit_btn_MouseLeave);
            this.Exit_btn.MouseHover += new System.EventHandler(this.Exit_btn_MouseHover);
            // 
            // credits_btn
            // 
            this.credits_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.credit_btn;
            this.credits_btn.Location = new System.Drawing.Point(180, 228);
            this.credits_btn.Name = "credits_btn";
            this.credits_btn.Size = new System.Drawing.Size(283, 122);
            this.credits_btn.TabIndex = 3;
            this.credits_btn.TabStop = false;
            this.credits_btn.Visible = false;
            this.credits_btn.Click += new System.EventHandler(this.credits_btn_Click);
            this.credits_btn.MouseLeave += new System.EventHandler(this.credits_btn_MouseLeave);
            this.credits_btn.MouseHover += new System.EventHandler(this.credits_btn_MouseHover);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.panel1);
            this.Name = "StartMenu";
            this.Text = "Start Game";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Options_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sound_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_game_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Options_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox new_game_btn;
        private System.Windows.Forms.PictureBox Save_btn;
        private System.Windows.Forms.PictureBox Options_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.PictureBox new_game_hover;
        private System.Windows.Forms.PictureBox Load_hover;
        private System.Windows.Forms.PictureBox Options_hover;
        private System.Windows.Forms.PictureBox Exit_hover;
        private System.Windows.Forms.Panel Options_panel;
        private System.Windows.Forms.PictureBox Difficulty_btn;
        private System.Windows.Forms.PictureBox Back_btn1;
        private System.Windows.Forms.PictureBox Sound_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox credits_btn;
    }
}
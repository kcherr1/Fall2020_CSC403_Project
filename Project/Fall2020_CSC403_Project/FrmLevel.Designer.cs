﻿namespace Fall2020_CSC403_Project {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.timer30 = new System.Windows.Forms.Timer(this.components);
            this.timerDashboard = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.picSquonkCaged = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.potion1 = new System.Windows.Forms.PictureBox();
            this.potion0 = new System.Windows.Forms.PictureBox();
            this.pit0 = new System.Windows.Forms.PictureBox();
            this.pit1 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picMushy = new System.Windows.Forms.PictureBox();
            this.potion2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSquonkCaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMushy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion2)).BeginInit();
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
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
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
            // timer30
            // 
            this.timer30.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDashboard
            // 
            this.timerDashboard.AutoSize = true;
            this.timerDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerDashboard.Location = new System.Drawing.Point(793, 235);
            this.timerDashboard.Name = "timerDashboard";
            this.timerDashboard.Size = new System.Drawing.Size(35, 82);
            this.timerDashboard.TabIndex = 25;
            this.timerDashboard.Text = "\r\n";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // picSquonkCaged
            // 
            this.picSquonkCaged.Image = global::Fall2020_CSC403_Project.Properties.Resources.squonk_cage;
            this.picSquonkCaged.Location = new System.Drawing.Point(1497, 57);
            this.picSquonkCaged.Name = "picSquonkCaged";
            this.picSquonkCaged.Size = new System.Drawing.Size(126, 71);
            this.picSquonkCaged.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSquonkCaged.TabIndex = 24;
            this.picSquonkCaged.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayer.BackgroundImage")));
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(103, 852);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(66, 138);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // potion1
            // 
            this.potion1.BackColor = System.Drawing.Color.Transparent;
            this.potion1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.potion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potion1.Location = new System.Drawing.Point(1556, 912);
            this.potion1.Name = "potion1";
            this.potion1.Size = new System.Drawing.Size(76, 88);
            this.potion1.TabIndex = 21;
            this.potion1.TabStop = false;
            // 
            // potion0
            // 
            this.potion0.BackColor = System.Drawing.Color.Transparent;
            this.potion0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.potion0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potion0.Location = new System.Drawing.Point(82, 335);
            this.potion0.Name = "potion0";
            this.potion0.Size = new System.Drawing.Size(87, 89);
            this.potion0.TabIndex = 20;
            this.potion0.TabStop = false;
            // 
            // pit0
            // 
            this.pit0.BackColor = System.Drawing.Color.Black;
            this.pit0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pit;
            this.pit0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pit0.Location = new System.Drawing.Point(208, 182);
            this.pit0.Name = "pit0";
            this.pit0.Size = new System.Drawing.Size(154, 252);
            this.pit0.TabIndex = 19;
            this.pit0.TabStop = false;
            // 
            // pit1
            // 
            this.pit1.BackColor = System.Drawing.Color.Black;
            this.pit1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pit;
            this.pit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pit1.Location = new System.Drawing.Point(884, 862);
            this.pit1.Name = "pit1";
            this.pit1.Size = new System.Drawing.Size(638, 152);
            this.pit1.TabIndex = 18;
            this.pit1.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.IndianRed;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(501, 611);
            this.picWall11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(46, 403);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.IndianRed;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(968, 452);
            this.picWall2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(532, 48);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.IndianRed;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1640, -26);
            this.picWall8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(123, 1138);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(968, 48);
            this.picWall7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(138, 408);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.IndianRed;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(36, 2);
            this.picWall1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(1365, 48);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.IndianRed;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(3, 2);
            this.picWall0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(74, 1022);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.IndianRed;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(600, 218);
            this.picWall10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(66, 383);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.IndianRed;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(62, 432);
            this.picWall9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(316, 31);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.RosyBrown;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(838, 740);
            this.picWall6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(50, 274);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.IndianRed;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(1251, 646);
            this.picWall12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(392, 82);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.IndianRed;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(290, 592);
            this.picWall4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(530, 29);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.IndianRed;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(3, 1009);
            this.picWall5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(1728, 103);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.IndianRed;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(3, 788);
            this.picWall3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(360, 46);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(431, 405);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(94, 148);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(874, 522);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(96, 165);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1475, 207);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(148, 235);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picMushy
            // 
            this.picMushy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.mushy;
            this.picMushy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMushy.Image = global::Fall2020_CSC403_Project.Properties.Resources.back;
            this.picMushy.Location = new System.Drawing.Point(550, 802);
            this.picMushy.Name = "picMushy";
            this.picMushy.Size = new System.Drawing.Size(281, 75);
            this.picMushy.TabIndex = 22;
            this.picMushy.TabStop = false;
            // 
            // potion2
            // 
            this.potion2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.potion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potion2.Location = new System.Drawing.Point(649, 912);
            this.potion2.Name = "potion2";
            this.potion2.Size = new System.Drawing.Size(89, 78);
            this.potion2.TabIndex = 23;
            this.potion2.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1756, 1050);
            this.Controls.Add(this.timerDashboard);
            this.Controls.Add(this.picSquonkCaged);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.potion1);
            this.Controls.Add(this.potion0);
            this.Controls.Add(this.pit0);
            this.Controls.Add(this.pit1);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picMushy);
            this.Controls.Add(this.potion2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picSquonkCaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMushy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox pit1;
        private System.Windows.Forms.PictureBox pit0;
        private System.Windows.Forms.PictureBox potion0;
        private System.Windows.Forms.PictureBox potion1;
        private System.Windows.Forms.PictureBox picMushy;
        private System.Windows.Forms.PictureBox potion2;
        private System.Windows.Forms.PictureBox picSquonkCaged;
        private System.Windows.Forms.Timer timer30;
        private System.Windows.Forms.Label timerDashboard;
        private System.Windows.Forms.Timer countdownTimer;
    }
}


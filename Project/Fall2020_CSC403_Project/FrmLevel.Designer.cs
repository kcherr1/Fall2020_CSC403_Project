using System;
using System.Collections.Generic;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.pictureWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.pictureWall11 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBattleDamageOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tmrEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.picWallTemplate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall11)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWallTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 35);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
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
            // picEnemyCheeto
            //
            var random = new Random();
            var list = new List<string> { "Indiana Jones", "Universal Monsters", "Doctor Who" };
            int Rogue = random.Next(list.Count);


            var random1 = new Random();
            var list1 = new List<string> { "Pipe Wall", "Stone Wall", "Brick Wall", "Wood Wall" };
            int WallPattern = random1.Next(list1.Count);
            if (Rogue == 0)
                Properties.Resources.enemy_cheetos = Properties.Resources.Villain_German_Mechanic;
                Properties.Resources.enemy_poisonpacket = Properties.Resources.Villain_Major_Toht;
                Properties.Resources.enemy_koolaid = Properties.Resources.Boss_Villain_Belloq;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Belloq__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Belloq__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Minotaur_versus_Belloq__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Amazo_versus_Belloq__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Mad_Hatter_versus_Belloq__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Corn_versus_Belloq__mp3cut_net___1_;
            if (Rogue == 1)
                Properties.Resources.enemy_cheetos=Properties.Resources.Villain_Wolfman;
                Properties.Resources.enemy_poisonpacket = Properties.Resources.Villain_Invisible_Man;
                Properties.Resources.enemy_koolaid=Properties.Resources.Boss_Villain_Dracula;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dracula__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dracula__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Minotaur_versus_Dracula__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Amazo_versus_Dracula__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Mad_Hatter_versus_Dracula__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Corn_versus_Dracula__mp3cut_net_;
            if (Rogue == 2)
                Properties.Resources.enemy_cheetos=Properties.Resources.Villain_Mondasian_Cyberman;
                Properties.Resources.enemy_poisonpacket=Properties.Resources.Villain_Delgado_Master;
                Properties.Resources.enemy_koolaid=Properties.Resources.Boss_Villain_Dalek;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dalek__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dalek__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Minotaur_versus_Dalek__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Amazo_versus_Dalek__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Mad_Hatter_versus_Dalek__mp3cut_net_;
                if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
                    Properties.Resources.final_battle = Properties.Resources.Final_Battle_Corn_versus_Dalek__mp3cut_net_;


            if (WallPattern == 0)
                Properties.Resources.wall = Properties.Resources.Pipe_Wall;
            if (WallPattern == 1)
                Properties.Resources.wall = Properties.Resources.Stone_Wall;
            if (WallPattern == 2)
                Properties.Resources.wall = Properties.Resources.Brick_Wall;
            if (WallPattern == 3)
                Properties.Resources.wall = Properties.Resources.Wood_Wall;



            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(45, 45);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 146);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(45, 45);
            this.picEnemyPoisonPacket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(0, 412);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            this.picWall3.Visible = false;
            this.picWall3.Click += new System.EventHandler(this.picWall3_Click);
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(900, 103);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(45, 45);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(751, 404);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(45, 45);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(0, 685);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            this.picWall5.Visible = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(0, 480);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            this.picWall4.Visible = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            this.picWall12.Visible = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 685);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            this.picWall6.Visible = false;
            // 
            // pictureWall9
            // 
            this.pictureWall9.BackColor = System.Drawing.Color.Transparent;
            this.pictureWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.pictureWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureWall9.Location = new System.Drawing.Point(323, 169);
            this.pictureWall9.Name = "pictureWall9";
            this.pictureWall9.Size = new System.Drawing.Size(109, 119);
            this.pictureWall9.TabIndex = 10;
            this.pictureWall9.TabStop = false;
            this.pictureWall9.Visible = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(652, 116);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(153, 126);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            this.picWall10.Visible = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(0, 23);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            this.picWall0.Visible = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(713, 685);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            this.picWall7.Visible = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1094, 103);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 649);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            this.picWall8.Visible = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(82, 23);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            this.picWall1.Visible = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 23);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(612, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            this.picWall2.Visible = false;
            // 
            // pictureWall11
            // 
            this.pictureWall11.BackColor = System.Drawing.Color.Transparent;
            this.pictureWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.pictureWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureWall11.Location = new System.Drawing.Point(551, 425);
            this.pictureWall11.Name = "pictureWall11";
            this.pictureWall11.Size = new System.Drawing.Size(164, 232);
            this.pictureWall11.TabIndex = 17;
            this.pictureWall11.TabStop = false;
            this.pictureWall11.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBattleDamageOptionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.fileToolStripMenuItem.Text = "Menu";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editBattleDamageOptionsToolStripMenuItem
            // 
            this.editBattleDamageOptionsToolStripMenuItem.Name = "editBattleDamageOptionsToolStripMenuItem";
            this.editBattleDamageOptionsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.editBattleDamageOptionsToolStripMenuItem.Text = "Edit Battle Damage Options";
            this.editBattleDamageOptionsToolStripMenuItem.Click += new System.EventHandler(this.editBattleDamageOptionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectionChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // tmrEnemyMove
            // 
            this.tmrEnemyMove.Enabled = true;
            this.tmrEnemyMove.Tick += new System.EventHandler(this.tmrEnemyMove_Tick);
            // 
            // picWallTemplate
            // 
            this.picWallTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWallTemplate.BackColor = System.Drawing.Color.Transparent;
            this.picWallTemplate.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picWallTemplate.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.InitialImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.Location = new System.Drawing.Point(570, 360);
            this.picWallTemplate.Name = "picWallTemplate";
            this.picWallTemplate.Size = new System.Drawing.Size(50, 50);
            this.picWallTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWallTemplate.TabIndex = 19;
            this.picWallTemplate.TabStop = false;
            this.picWallTemplate.Visible = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Controls.Add(this.picWallTemplate);
            this.Controls.Add(this.pictureWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.pictureWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall11)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWallTemplate)).EndInit();
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
    private System.Windows.Forms.PictureBox pictureWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox pictureWall11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBattleDamageOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Timer tmrEnemyMove;
        private System.Windows.Forms.PictureBox picWallTemplate;
    }
}


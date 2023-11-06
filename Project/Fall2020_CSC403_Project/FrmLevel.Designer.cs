using System.Media;

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
        this.levelTheme.Stop();
      }
      base.Dispose(disposing);
        }
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    public void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.lblPlayerHealthMap = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picEnemyGRIMACE = new System.Windows.Forms.PictureBox();
            this.picEnemyRaisin = new System.Windows.Forms.PictureBox();
            this.picBossPrimordialKoolaid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall13 = new System.Windows.Forms.PictureBox();
            this.picWall14 = new System.Windows.Forms.PictureBox();
            this.picWall15 = new System.Windows.Forms.PictureBox();
            this.picWall16 = new System.Windows.Forms.PictureBox();
            this.picWall17 = new System.Windows.Forms.PictureBox();
            this.picWall18 = new System.Windows.Forms.PictureBox();
            this.picWall19 = new System.Windows.Forms.PictureBox();
            this.picWall20 = new System.Windows.Forms.PictureBox();
            this.picWall21 = new System.Windows.Forms.PictureBox();
            this.picWall22 = new System.Windows.Forms.PictureBox();
            this.picWall23 = new System.Windows.Forms.PictureBox();
            this.picWall24 = new System.Windows.Forms.PictureBox();
            this.picAreaDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyGRIMACE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyRaisin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossPrimordialKoolaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            // 
            // lblPlayerHealthMap, Displays player health on the overworld
            // 
            this.lblPlayerHealthMap.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthMap.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthMap.Location = new System.Drawing.Point(12, 690);
            this.lblPlayerHealthMap.Name = "lblPlayerHealthMap";
            this.lblPlayerHealthMap.Size = new System.Drawing.Size(226, 23);
            this.lblPlayerHealthMap.TabIndex = 0;
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
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;

            // 
            // picEnemyGRIMACE
            // 
            this.picEnemyGRIMACE.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyGRIMACE.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.G_R_I_M_A_C_E_;
            this.picEnemyGRIMACE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyGRIMACE.Location = new System.Drawing.Point(0, 0);
            this.picEnemyGRIMACE.Name = "picEnemyCheeto";
            this.picEnemyGRIMACE.Size = new System.Drawing.Size(63, 96);
            this.picEnemyGRIMACE.TabIndex = 12;
            this.picEnemyGRIMACE.TabStop = false;

            // 
            // picEnemyRaisin
            // 
            this.picEnemyRaisin.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyRaisin.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanut_end;
            this.picEnemyRaisin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyRaisin.Location = new System.Drawing.Point(0, 0);
            this.picEnemyRaisin.Name = "picEnemyRaisin";
            this.picEnemyRaisin.Size = new System.Drawing.Size(63, 96);
            this.picEnemyRaisin.TabIndex = 13;
            this.picEnemyRaisin.TabStop = false;

            // 
            // picBossPrimordialKoolaid
            // 
            this.picBossPrimordialKoolaid.BackColor = System.Drawing.Color.Transparent;
            this.picBossPrimordialKoolaid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.The_Primoridal_Juice;
            this.picBossPrimordialKoolaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossPrimordialKoolaid.Location = new System.Drawing.Point(0, 0);
            this.picBossPrimordialKoolaid.Name = "picBossPrimorialKoolaid";
            this.picBossPrimordialKoolaid.Size = new System.Drawing.Size(193, 194);
            this.picBossPrimordialKoolaid.TabIndex = 14;
            this.picBossPrimordialKoolaid.TabStop = false;


            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(900, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
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
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(266, 154);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(653, 89);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1099, 274);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(650, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            //
            // these walls will be displaced and replaced when world two is needed
            // (picWall13-picWall19)
            // picWall 13
            this.picWall13.BackColor = System.Drawing.Color.Transparent;
            this.picWall13.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall13.Location = new System.Drawing.Point(80, 400);
            this.picWall13.Name = "picWall13";
            this.picWall13.Size = new System.Drawing.Size(382, 67);
            this.picWall13.TabIndex = 17;
            this.picWall13.TabStop = false;
            // picWall 14
            this.picWall14.BackColor = System.Drawing.Color.Transparent;
            this.picWall14.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall14.Location = new System.Drawing.Point(0, 660);
            this.picWall14.Name = "picWall14";
            this.picWall14.Size = new System.Drawing.Size(560, 67);
            this.picWall14.TabIndex = 17;
            this.picWall14.TabStop = false;
            // picWall 15
            this.picWall15.BackColor = System.Drawing.Color.Transparent;
            this.picWall15.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall15.Location = new System.Drawing.Point(0, 0);
            this.picWall15.Name = "picWall15";
            this.picWall15.Size = new System.Drawing.Size(82, 467);
            this.picWall15.TabIndex = 17;
            this.picWall15.TabStop = false;
            // picWall 16
            this.picWall16.BackColor = System.Drawing.Color.Transparent;
            this.picWall16.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall16.Location = new System.Drawing.Point(1095, 0);
            this.picWall16.Name = "picWall16";
            this.picWall16.Size = new System.Drawing.Size(82, 725);
            this.picWall16.TabIndex = 17;
            this.picWall16.TabStop = false;
            // picWall 17
            this.picWall17.BackColor = System.Drawing.Color.Transparent;
            this.picWall17.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall17.Location = new System.Drawing.Point(560, 660);
            this.picWall17.Name = "picWall17";
            this.picWall17.Size = new System.Drawing.Size(535, 67);
            this.picWall17.TabIndex = 17;
            this.picWall17.TabStop = false;
            // picWall 18
            this.picWall18.BackColor = System.Drawing.Color.Transparent;
            this.picWall18.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall18.Location = new System.Drawing.Point(0, 0);
            this.picWall18.Name = "picWall18";
            this.picWall18.Size = new System.Drawing.Size(1100, 67);
            this.picWall18.TabIndex = 17;
            this.picWall18.TabStop = false;
            // picWall 19
            this.picWall19.BackColor = System.Drawing.Color.Transparent;
            this.picWall19.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall19.Location = new System.Drawing.Point(714, 400);
            this.picWall19.Name = "picWall19";
            this.picWall19.Size = new System.Drawing.Size(382, 67);
            this.picWall19.TabIndex = 17;
            this.picWall19.TabStop = false;
            //
            // these walls will be displaced and replaced when the secret world is needed
            // (picWall20-picWall24)
            // picWall 20
            this.picWall20.BackColor = System.Drawing.Color.Transparent;
            this.picWall20.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall20.Location = new System.Drawing.Point(80, 675);
            this.picWall20.Name = "picWall20";
            this.picWall20.Size = new System.Drawing.Size(1040, 67);
            this.picWall20.TabIndex = 17;
            this.picWall20.TabStop = false;
            // picWall 21
            this.picWall21.BackColor = System.Drawing.Color.Transparent;
            this.picWall21.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall21.Location = new System.Drawing.Point(0, 0);
            this.picWall21.Name = "picWall21";
            this.picWall21.Size = new System.Drawing.Size(82, 725);
            this.picWall21.TabIndex = 17;
            this.picWall21.TabStop = false;
            // picWall 22
            this.picWall22.BackColor = System.Drawing.Color.Transparent;
            this.picWall22.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall22.Location = new System.Drawing.Point(1095, 0);
            this.picWall22.Name = "picWall22";
            this.picWall22.Size = new System.Drawing.Size(82, 725);
            this.picWall22.TabIndex = 17;
            this.picWall22.TabStop = false;
            // picWall 23
            this.picWall23.BackColor = System.Drawing.Color.Transparent;
            this.picWall23.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall23.Location = new System.Drawing.Point(0, 0);
            this.picWall23.Name = "picWall23";
            this.picWall23.Size = new System.Drawing.Size(1100, 67);
            this.picWall23.TabIndex = 17;
            this.picWall23.TabStop = false;
            // picWall 24
            this.picWall24.BackColor = System.Drawing.Color.Transparent;
            this.picWall24.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall24.Location = new System.Drawing.Point(80, 675);
            this.picWall24.Name = "picWall24";
            this.picWall24.Size = new System.Drawing.Size(1000, 67);
            this.picWall24.TabIndex = 17;
            this.picWall24.TabStop = false;
            //
            // the area door which changes the structure of the world upon player interaction
            //
            this.picAreaDoor.BackColor = System.Drawing.Color.Transparent;
            this.picAreaDoor.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picAreaDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAreaDoor.Location = new System.Drawing.Point(100, 200); // 1140, 67 (original coordinates) 100 200 (Test coordinates)
            this.picAreaDoor.Name = "picAreaDoor";
            this.picAreaDoor.Size = new System.Drawing.Size(50, 220);
            this.picAreaDoor.TabIndex = 17;
            this.picAreaDoor.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.lblPlayerHealthMap);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picEnemyGRIMACE);
            this.Controls.Add(this.picEnemyRaisin);
            this.Controls.Add(this.picBossPrimordialKoolaid);
            this.Controls.Add(this.picWall13);
            this.Controls.Add(this.picWall14);
            this.Controls.Add(this.picWall15);
            this.Controls.Add(this.picWall16);
            this.Controls.Add(this.picWall17);
            this.Controls.Add(this.picWall18);
            this.Controls.Add(this.picWall19);
            this.Controls.Add(this.picWall20);
            this.Controls.Add(this.picWall21);
            this.Controls.Add(this.picWall22);
            this.Controls.Add(this.picWall23);
            this.Controls.Add(this.picWall24);
            this.Controls.Add(this.picAreaDoor);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyGRIMACE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyRaisin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossPrimordialKoolaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDoor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.PictureBox picPlayer;
        public System.Windows.Forms.PictureBox picBossKoolAid;
        public System.Windows.Forms.Label lblInGameTime;
        public System.Windows.Forms.Timer tmrUpdateInGameTime;
        public System.Windows.Forms.Timer tmrPlayerMove;
        public System.Windows.Forms.PictureBox picWall3;
        public System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        public System.Windows.Forms.PictureBox picEnemyGRIMACE;
        public System.Windows.Forms.PictureBox picEnemyRaisin;
        public System.Windows.Forms.PictureBox picBossPrimordialKoolaid;
        public System.Windows.Forms.PictureBox picEnemyCheeto;
        public System.Windows.Forms.Label lblPlayerHealthMap;
        public System.Windows.Forms.PictureBox picWall5;
        public System.Windows.Forms.PictureBox picWall4;
        public System.Windows.Forms.PictureBox picWall12;
        public System.Windows.Forms.PictureBox picWall6;
        public System.Windows.Forms.PictureBox picWall9;
        public System.Windows.Forms.PictureBox picWall10;
        public System.Windows.Forms.PictureBox picWall0;
        public System.Windows.Forms.PictureBox picWall7;
        public System.Windows.Forms.PictureBox picWall8;
        public System.Windows.Forms.PictureBox picWall1;
        public System.Windows.Forms.PictureBox picWall2;
        public System.Windows.Forms.PictureBox picWall11;
        public System.Windows.Forms.PictureBox picWall13;
        public System.Windows.Forms.PictureBox picWall14;
        public System.Windows.Forms.PictureBox picWall15;
        public System.Windows.Forms.PictureBox picWall16;
        public System.Windows.Forms.PictureBox picWall17;
        public System.Windows.Forms.PictureBox picWall18;
        public System.Windows.Forms.PictureBox picWall19;
        public System.Windows.Forms.PictureBox picWall20;
        public System.Windows.Forms.PictureBox picWall21;
        public System.Windows.Forms.PictureBox picWall22;
        public System.Windows.Forms.PictureBox picWall23;
        public System.Windows.Forms.PictureBox picWall24;
        public System.Windows.Forms.PictureBox picAreaDoor;
    SoundPlayer levelTheme = new SoundPlayer("level_theme.wav");

    }
}


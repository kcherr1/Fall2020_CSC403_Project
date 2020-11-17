namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.Dialogue1 = new System.Windows.Forms.Label();
            this.Dialogue2 = new System.Windows.Forms.Label();
            this.Dialogue3 = new System.Windows.Forms.Label();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.lblExperienceBar = new System.Windows.Forms.Label();
            this.lblExperienceBarBackground = new System.Windows.Forms.Label();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.lblEnemyXP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(162, 472);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(171, 53);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(162, 559);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(171, 53);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Escape";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // LabelDialogue1
            // 
            this.Dialogue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dialogue1.Location = new System.Drawing.Point(410, 380);
            this.Dialogue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dialogue1.Name = "Dialogue1";
            this.Dialogue1.Size = new System.Drawing.Size(456, 121);
            this.Dialogue1.TabIndex = 4;
            this.Dialogue1.Text = this.randomText1();
            this.Dialogue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDialogue2
            // 
            this.Dialogue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dialogue2.Location = new System.Drawing.Point(390, 380);
            this.Dialogue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dialogue2.Name = "Dialogue1";
            this.Dialogue2.Size = new System.Drawing.Size(456, 121);
            this.Dialogue2.TabIndex = 4;
            this.Dialogue2.Text = this.randomText2();
            this.Dialogue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDialogue3
            // 
            this.Dialogue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dialogue3.Location = new System.Drawing.Point(390, 380);
            this.Dialogue3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dialogue3.Name = "Dialogue1";
            this.Dialogue3.Size = new System.Drawing.Size(456, 121);
            this.Dialogue3.TabIndex = 4;
            this.Dialogue3.Text = this.randomText3();
            this.Dialogue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(95, 74);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(301, 25);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 28);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(687, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 28);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(688, 74);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(301, 25);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1040, 693);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(4);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(40, 34);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(687, 121);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(304, 328);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(93, 121);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(304, 328);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // lblExperienceBar
            // 
            this.lblExperienceBar.BackColor = System.Drawing.Color.Indigo;
            this.lblExperienceBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceBar.ForeColor = System.Drawing.Color.White;
            this.lblExperienceBar.Location = new System.Drawing.Point(98, 9);
            this.lblExperienceBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperienceBar.Name = "lblExperienceBar";
            this.lblExperienceBar.Size = new System.Drawing.Size(899, 36);
            this.lblExperienceBar.TabIndex = 10;
            // 
            // lblExperienceBarBackground
            // 
            this.lblExperienceBarBackground.BackColor = System.Drawing.Color.Black;
            this.lblExperienceBarBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExperienceBarBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceBarBackground.ForeColor = System.Drawing.Color.White;
            this.lblExperienceBarBackground.Location = new System.Drawing.Point(100, 9);
            this.lblExperienceBarBackground.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperienceBarBackground.Name = "lblExperienceBarBackground";
            this.lblExperienceBarBackground.Size = new System.Drawing.Size(897, 37);
            this.lblExperienceBarBackground.TabIndex = 11;
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.BackColor = System.Drawing.Color.MediumPurple;
            this.lblCurrentLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLevel.ForeColor = System.Drawing.Color.White;
            this.lblCurrentLevel.Location = new System.Drawing.Point(13, 9);
            this.lblCurrentLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(88, 37);
            this.lblCurrentLevel.TabIndex = 12;
            // 
            // lblEnemyXP
            // 
            this.lblEnemyXP.BackColor = System.Drawing.Color.MediumPurple;
            this.lblEnemyXP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnemyXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyXP.ForeColor = System.Drawing.Color.White;
            this.lblEnemyXP.Location = new System.Drawing.Point(903, 130);
            this.lblEnemyXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyXP.Name = "lblEnemyXP";
            this.lblEnemyXP.Size = new System.Drawing.Size(76, 31);
            this.lblEnemyXP.TabIndex = 13;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 742);
            this.Controls.Add(this.lblEnemyXP);
            this.Controls.Add(this.lblCurrentLevel);
            this.Controls.Add(this.lblExperienceBar);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblExperienceBarBackground);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            this.Load += new System.EventHandler(this.FrmBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
	private System.Windows.Forms.Button btnRun;
	private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
	private System.Windows.Forms.Label lblExperienceBar;
	private System.Windows.Forms.Label lblExperienceBarBackground;
	private System.Windows.Forms.Label lblCurrentLevel;
	private System.Windows.Forms.Label lblEnemyXP;
    private System.Windows.Forms.Label Dialogue1;
    private System.Windows.Forms.Label Dialogue2;
    private System.Windows.Forms.Label Dialogue3;
    }
}
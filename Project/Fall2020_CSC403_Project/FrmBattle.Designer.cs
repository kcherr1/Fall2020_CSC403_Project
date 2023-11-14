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
      this.lblPlayerHealthFull = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblEnemyHealthFull = new System.Windows.Forms.Label();
      this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
      this.Heal = new System.Windows.Forms.Button();
      this.HealthPackCountLabel = new System.Windows.Forms.Label();
      this.picBossBattleImposter = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.gunfireBlast = new System.Windows.Forms.PictureBox();
      this.weapon = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.picBossBattle = new System.Windows.Forms.PictureBox();
      this.picBossBattleSquirrels = new System.Windows.Forms.PictureBox();
      this.picEnemy = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattleImposter)).BeginInit();
      this.PlayerLevel = new System.Windows.Forms.Label();
      this.FleeButton = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gunfireBlast)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.weapon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattleSquirrels)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAttack
      // 
      this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAttack.Location = new System.Drawing.Point(316, 728);
      this.btnAttack.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.btnAttack.Name = "btnAttack";
      this.btnAttack.Size = new System.Drawing.Size(341, 115);
      this.btnAttack.TabIndex = 2;
      this.btnAttack.Text = "Attack";
      this.btnAttack.UseVisualStyleBackColor = true;
      this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
      // 
      // lblPlayerHealthFull
      // 
      this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblPlayerHealthFull.Location = new System.Drawing.Point(188, 143);
      this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
      this.lblPlayerHealthFull.Size = new System.Drawing.Size(603, 48);
      this.lblPlayerHealthFull.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Location = new System.Drawing.Point(187, 141);
      this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(612, 54);
      this.label1.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Location = new System.Drawing.Point(1372, 141);
      this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(612, 54);
      this.label2.TabIndex = 5;
      // 
      // lblEnemyHealthFull
      // 
      this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblEnemyHealthFull.Location = new System.Drawing.Point(1376, 143);
      this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
      this.lblEnemyHealthFull.Size = new System.Drawing.Size(603, 48);
      this.lblEnemyHealthFull.TabIndex = 6;
      // 
      // tmrFinalBattle
      // 
      this.tmrFinalBattle.Interval = 5600;
      this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
      // 
      // Heal
      // 
      this.Heal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F);
      this.Heal.Location = new System.Drawing.Point(316, 880);
      this.Heal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Heal.Name = "Heal";
      this.Heal.Size = new System.Drawing.Size(341, 115);
      this.Heal.TabIndex = 8;
      this.Heal.Text = "Heal";
      this.Heal.UseVisualStyleBackColor = true;
      this.Heal.Click += new System.EventHandler(this.Heal_Click);
      // 
      // HealthPackCountLabel
      // 
      this.HealthPackCountLabel.AutoSize = true;
      this.HealthPackCountLabel.BackColor = System.Drawing.Color.Black;
      this.HealthPackCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.HealthPackCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.HealthPackCountLabel.Location = new System.Drawing.Point(827, 938);
      this.HealthPackCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.HealthPackCountLabel.Name = "HealthPackCountLabel";
      this.HealthPackCountLabel.Size = new System.Drawing.Size(42, 46);
      this.HealthPackCountLabel.TabIndex = 10;
      this.HealthPackCountLabel.Text = "3";
      // 
      // picBossBattleImposter
      // 
      this.picBossBattleImposter.BackColor = System.Drawing.Color.Maroon;
      this.picBossBattleImposter.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen_imposter;
      this.picBossBattleImposter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattleImposter.Location = new System.Drawing.Point(1040, 694);
      this.picBossBattleImposter.Margin = new System.Windows.Forms.Padding(4);
      this.picBossBattleImposter.Name = "picBossBattleImposter";
      this.picBossBattleImposter.Size = new System.Drawing.Size(40, 34);
      this.picBossBattleImposter.TabIndex = 14;
      this.picBossBattleImposter.TabStop = false;
      this.picBossBattleImposter.Visible = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen_squirrels;
      this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox2.Location = new System.Drawing.Point(2082, 1345);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(80, 65);
      this.pictureBox2.TabIndex = 13;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Visible = false;
      // 
      // gunfireBlast
      // 
      this.gunfireBlast.Image = global::Fall2020_CSC403_Project.Properties.Resources.gunfireBlast;
      this.gunfireBlast.Location = new System.Drawing.Point(860, 746);
      this.gunfireBlast.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gunfireBlast.Name = "gunfireBlast";
      this.gunfireBlast.Size = new System.Drawing.Size(53, 43);
      this.gunfireBlast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.gunfireBlast.TabIndex = 12;
      this.gunfireBlast.TabStop = false;
      this.gunfireBlast.Visible = false;
      // 
      // weapon
      // 
      this.weapon.BackColor = System.Drawing.Color.Transparent;
      this.weapon.Image = global::Fall2020_CSC403_Project.Properties.Resources.weapon1;
      this.weapon.Location = new System.Drawing.Point(690, 728);
      this.weapon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.weapon.Name = "weapon";
      this.weapon.Size = new System.Drawing.Size(185, 115);
      this.weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.weapon.TabIndex = 11;
      this.weapon.TabStop = false;
      this.weapon.Visible = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Black;
      this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.health_pack;
      this.pictureBox1.Location = new System.Drawing.Point(690, 880);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(185, 115);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // picBossBattle
      // 
      this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
      this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattle.Location = new System.Drawing.Point(2080, 1342);
      this.picBossBattle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picBossBattle.Name = "picBossBattle";
      this.picBossBattle.Size = new System.Drawing.Size(80, 65);
      this.picBossBattle.TabIndex = 7;
      this.picBossBattle.TabStop = false;
      this.picBossBattle.Visible = false;
      // 
      // picBossBattleSquirrels
      // 
      this.picBossBattleSquirrels.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen_squirrels;
      this.picBossBattleSquirrels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattleSquirrels.Location = new System.Drawing.Point(1170, 866);
      this.picBossBattleSquirrels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.picBossBattleSquirrels.Name = "picBossBattleSquirrels";
      this.picBossBattleSquirrels.Size = new System.Drawing.Size(45, 43);
      this.picBossBattleSquirrels.TabIndex = 7;
      this.picBossBattleSquirrels.TabStop = false;
      this.picBossBattleSquirrels.Visible = false;
      // 
      // picEnemy
      // 
      this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
      this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picEnemy.Location = new System.Drawing.Point(1465, 223);
      this.picEnemy.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picEnemy.Name = "picEnemy";
      this.picEnemy.Size = new System.Drawing.Size(447, 450);
      this.picEnemy.TabIndex = 1;
      this.picEnemy.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picPlayer.Location = new System.Drawing.Point(290, 223);
      this.picPlayer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(408, 450);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // PlayerLevel
      // 
      this.PlayerLevel.BackColor = System.Drawing.Color.DarkOrange;
      this.PlayerLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.PlayerLevel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlayerLevel.Location = new System.Drawing.Point(254, 82);
      this.PlayerLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.PlayerLevel.Name = "PlayerLevel";
      this.PlayerLevel.Size = new System.Drawing.Size(475, 60);
      this.PlayerLevel.TabIndex = 13;
      this.PlayerLevel.Text = "Level: 0 Exp: 0/20";
      this.PlayerLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.PlayerLevel.Click += new System.EventHandler(this.PlayerLevel_Click);
      // 
      // picBossBattleSquirrels
      // 
      this.picBossBattleSquirrels.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen_squirrels;
      this.picBossBattleSquirrels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattleSquirrels.Location = new System.Drawing.Point(2340, 1677);
      this.picBossBattleSquirrels.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
      this.picBossBattleSquirrels.Name = "picBossBattleSquirrels";
      this.picBossBattleSquirrels.Size = new System.Drawing.Size(91, 84);
      this.picBossBattleSquirrels.TabIndex = 7;
      this.picBossBattleSquirrels.TabStop = false;
      this.picBossBattleSquirrels.Visible = false;
      // 
      // FleeButton
      // 
      this.FleeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F);
      this.FleeButton.Location = new System.Drawing.Point(316, 1036);
      this.FleeButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.FleeButton.Name = "FleeButton";
      this.FleeButton.Size = new System.Drawing.Size(341, 115);
      this.FleeButton.TabIndex = 14;
      this.FleeButton.Text = "Flee";
      this.FleeButton.UseVisualStyleBackColor = true;
      this.FleeButton.Click += new System.EventHandler(this.FleeButton_Click);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Green;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.textBox1.Location = new System.Drawing.Point(699, 1036);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(339, 53);
      this.textBox1.TabIndex = 15;
      this.textBox1.Text = "50% Chance of";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.Color.Green;
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.textBox2.Location = new System.Drawing.Point(690, 1098);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(359, 53);
      this.textBox2.TabIndex = 16;
      this.textBox2.Text = "Successful Flee";
      // 
      // FrmBattle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.Green;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(2101, 1403);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.FleeButton);
      this.Controls.Add(this.PlayerLevel);
      this.ClientSize = new System.Drawing.Size(1051, 724);
      this.Controls.Add(this.picBossBattleImposter);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.gunfireBlast);
      this.Controls.Add(this.weapon);
      this.Controls.Add(this.HealthPackCountLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.Heal);
      this.Controls.Add(this.picBossBattle);
      this.Controls.Add(this.picBossBattleSquirrels);
      this.Controls.Add(this.lblEnemyHealthFull);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblPlayerHealthFull);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnAttack);
      this.Controls.Add(this.picEnemy);
      this.Controls.Add(this.picPlayer);
      this.DoubleBuffered = true;
      this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.Name = "FrmBattle";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Fight!";
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattleImposter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gunfireBlast)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.weapon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattleSquirrels)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.PictureBox picBossBattleSquirrels;
    private System.Windows.Forms.Timer tmrFinalBattle;
    private System.Windows.Forms.Button Heal;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label HealthPackCountLabel;
    private System.Windows.Forms.PictureBox weapon;
    private System.Windows.Forms.PictureBox gunfireBlast;
    private System.Windows.Forms.Label PlayerLevel;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Button FleeButton;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.PictureBox picBossBattleImposter;
  }
}
﻿// The GUI initalizer for the battleground

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
			this.btnAttack_Melee = new System.Windows.Forms.Button(); // This initializes a button
			this.btnAttack_Ranged = new System.Windows.Forms.Button();
			this.btnAttack_Magic = new System.Windows.Forms.Button();
      this.btnUseItem = new System.Windows.Forms.Button();
			this.lblPlayerHealthFull = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblEnemyHealthFull = new System.Windows.Forms.Label();
      this.picBossBattle = new System.Windows.Forms.PictureBox();
      this.picEnemy = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAttack Melee
      // 
      this.btnAttack_Melee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAttack_Melee.Location = new System.Drawing.Point(70, 422);
      this.btnAttack_Melee.Name = "btnAttack_Melee";
      this.btnAttack_Melee.Size = new System.Drawing.Size(128, 43);
      this.btnAttack_Melee.TabIndex = 2;
      this.btnAttack_Melee.Text = "Melee";
      this.btnAttack_Melee.UseVisualStyleBackColor = true;
      this.btnAttack_Melee.Click += new System.EventHandler(this.btnAttack_ClickMelee);

      // btnAttack Ranged
			this.btnAttack_Ranged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAttack_Ranged.Location = new System.Drawing.Point(70, 465);
			this.btnAttack_Ranged.Name = "btnAttack_Ranged";
			this.btnAttack_Ranged.Size = new System.Drawing.Size(128, 43);
			this.btnAttack_Ranged.TabIndex = 2;
			this.btnAttack_Ranged.Text = "Ranged";
			this.btnAttack_Ranged.UseVisualStyleBackColor = true;
			this.btnAttack_Ranged.Click += new System.EventHandler(this.btnAttack_ClickRanged);

      // btnAttack Magic
			this.btnAttack_Magic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAttack_Magic.Location = new System.Drawing.Point(70, 508);
			this.btnAttack_Magic.Name = "btnAttack_Magic";
			this.btnAttack_Magic.Size = new System.Drawing.Size(128, 43);
			this.btnAttack_Magic.TabIndex = 2;
			this.btnAttack_Magic.Text = "Magic";
			this.btnAttack_Magic.UseVisualStyleBackColor = true;
			this.btnAttack_Magic.Click += new System.EventHandler(this.btnAttack_ClickMagic);

      // btnUseItem
			this.btnUseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUseItem.Location = new System.Drawing.Point(198, 422);
			this.btnUseItem.Name = "btnUseItem";
			this.btnUseItem.Size = new System.Drawing.Size(128, 43);
			this.btnUseItem.TabIndex = 2;
			this.btnUseItem.Text = "Use Item";
			this.btnUseItem.UseVisualStyleBackColor = true;
			this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);

			// 
			// lblPlayerHealthFull
			// 
			this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblPlayerHealthFull.Location = new System.Drawing.Point(71, 60);
      this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
      this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
      this.lblPlayerHealthFull.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Location = new System.Drawing.Point(70, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(229, 23);
      this.label1.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Location = new System.Drawing.Point(515, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(229, 23);
      this.label2.TabIndex = 5;
      // 
      // lblEnemyHealthFull
      // 
      this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblEnemyHealthFull.Location = new System.Drawing.Point(516, 60);
      this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
      this.lblEnemyHealthFull.Size = new System.Drawing.Size(226, 20);
      this.lblEnemyHealthFull.TabIndex = 6;
      // 
      // picBossBattle
      // 
      this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
      this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattle.Location = new System.Drawing.Point(780, 563);
      this.picBossBattle.Name = "picBossBattle";
      this.picBossBattle.Size = new System.Drawing.Size(30, 28);
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
      this.picEnemy.Location = new System.Drawing.Point(515, 98);
      this.picEnemy.Name = "picEnemy";
      this.picEnemy.Size = new System.Drawing.Size(229, 267);
      this.picEnemy.TabIndex = 1;
      this.picEnemy.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picPlayer.Location = new System.Drawing.Point(70, 98);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(229, 267);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // tmrFinalBattle
      // 
      this.tmrFinalBattle.Interval = 5600;
      this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
      // 
      // FrmBattle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Green;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(822, 603);
      this.Controls.Add(this.picBossBattle);
      this.Controls.Add(this.lblEnemyHealthFull);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblPlayerHealthFull);
      this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAttack_Melee);
			this.Controls.Add(this.btnAttack_Ranged);
			this.Controls.Add(this.btnAttack_Magic);
      this.Controls.Add(this.btnUseItem);
			this.Controls.Add(this.picEnemy);
      this.Controls.Add(this.picPlayer);
      this.DoubleBuffered = true;
      this.Name = "FrmBattle";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Fight!";
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
		private System.Windows.Forms.Button btnAttack_Melee;
		private System.Windows.Forms.Button btnAttack_Ranged;
		private System.Windows.Forms.Button btnAttack_Magic;
    private System.Windows.Forms.Button btnUseItem;
		private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
  }
}
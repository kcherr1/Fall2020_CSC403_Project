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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattle));
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.message1 = new System.Windows.Forms.PictureBox();
            this.message2 = new System.Windows.Forms.PictureBox();
            this.message3 = new System.Windows.Forms.PictureBox();
            this.message4 = new System.Windows.Forms.PictureBox();
            this.message5 = new System.Windows.Forms.PictureBox();
            this.message6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(127, 422);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(128, 43);
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
            // message1
            // 
            this.message1.BackColor = System.Drawing.Color.Transparent;
            this.message1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message1.BackgroundImage")));
            this.message1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message1.Location = new System.Drawing.Point(666, 85);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(105, 98);
            this.message1.TabIndex = 8;
            this.message1.TabStop = false;
            this.message1.Visible = false;
            // 
            // message2
            // 
            this.message2.BackColor = System.Drawing.Color.Transparent;
            this.message2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message2.BackgroundImage")));
            this.message2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message2.Location = new System.Drawing.Point(666, 85);
            this.message2.Name = "message2";
            this.message2.Size = new System.Drawing.Size(105, 98);
            this.message2.TabIndex = 9;
            this.message2.TabStop = false;
            this.message2.Visible = false;
            // 
            // message3
            // 
            this.message3.BackColor = System.Drawing.Color.Transparent;
            this.message3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message3.BackgroundImage")));
            this.message3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message3.Location = new System.Drawing.Point(666, 85);
            this.message3.Name = "message3";
            this.message3.Size = new System.Drawing.Size(105, 98);
            this.message3.TabIndex = 10;
            this.message3.TabStop = false;
            this.message3.Visible = false;
            // 
            // message4
            // 
            this.message4.BackColor = System.Drawing.Color.Transparent;
            this.message4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message4.BackgroundImage")));
            this.message4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message4.Location = new System.Drawing.Point(666, 85);
            this.message4.Name = "message4";
            this.message4.Size = new System.Drawing.Size(105, 98);
            this.message4.TabIndex = 11;
            this.message4.TabStop = false;
            this.message4.Visible = false;
            // 
            // message5
            // 
            this.message5.BackColor = System.Drawing.Color.Transparent;
            this.message5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message5.BackgroundImage")));
            this.message5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message5.Location = new System.Drawing.Point(666, 85);
            this.message5.Name = "message5";
            this.message5.Size = new System.Drawing.Size(105, 98);
            this.message5.TabIndex = 12;
            this.message5.TabStop = false;
            this.message5.Visible = false;
            // 
            // message6
            // 
            this.message6.BackColor = System.Drawing.Color.Transparent;
            this.message6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("message6.BackgroundImage")));
            this.message6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.message6.Location = new System.Drawing.Point(666, 85);
            this.message6.Name = "message6";
            this.message6.Size = new System.Drawing.Size(105, 98);
            this.message6.TabIndex = 13;
            this.message6.TabStop = false;
            this.message6.Visible = false;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 603);
            this.Controls.Add(this.message6);
            this.Controls.Add(this.message5);
            this.Controls.Add(this.message4);
            this.Controls.Add(this.message3);
            this.Controls.Add(this.message2);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message6)).EndInit();
            this.ResumeLayout(false);

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
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.PictureBox message1;
        private System.Windows.Forms.PictureBox message2;
        private System.Windows.Forms.PictureBox message3;
        private System.Windows.Forms.PictureBox message4;
        private System.Windows.Forms.PictureBox message5;
        private System.Windows.Forms.PictureBox message6;
    }
}
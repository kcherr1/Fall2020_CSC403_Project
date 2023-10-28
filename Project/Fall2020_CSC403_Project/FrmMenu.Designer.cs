namespace Fall2020_CSC403_Project
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.squonkCage = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            this.cutscene = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.squonkCage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutscene)).BeginInit();
            this.SuspendLayout();
            // 
            // squonkCage
            // 
            this.squonkCage.BackColor = System.Drawing.Color.Transparent;
            this.squonkCage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squonkCage.BackgroundImage")));
            this.squonkCage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.squonkCage.Location = new System.Drawing.Point(794, 128);
            this.squonkCage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.squonkCage.Name = "squonkCage";
            this.squonkCage.Size = new System.Drawing.Size(864, 825);
            this.squonkCage.TabIndex = 0;
            this.squonkCage.TabStop = false;
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("MV Boli", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(94, 212);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(788, 139);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "Squonk Rescue";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.playBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(228, 414);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(334, 149);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Silver;
            this.quitBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(228, 778);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(334, 146);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "Exit Game";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.helpBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(228, 598);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(334, 146);
            this.helpBtn.TabIndex = 3;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(1509, 962);
            this.skipBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(207, 108);
            this.skipBtn.TabIndex = 6;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // cutscene
            // 
            this.cutscene.Enabled = true;
            this.cutscene.Location = new System.Drawing.Point(0, 0);
            this.cutscene.Margin = new System.Windows.Forms.Padding(0);
            this.cutscene.Name = "cutscene";
            this.cutscene.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cutscene.OcxState")));
            this.cutscene.Size = new System.Drawing.Size(1786, 1173);
            this.cutscene.TabIndex = 5;
            this.cutscene.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.cutscene_PlayStateChange);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1764, 1117);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.cutscene);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.squonkCage);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.squonkCage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutscene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox squonkCage;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button helpBtn;
        private AxWMPLib.AxWindowsMediaPlayer cutscene;
        private System.Windows.Forms.Button skipBtn;
    }
}
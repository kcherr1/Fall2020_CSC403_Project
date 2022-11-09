
namespace Fall2020_CSC403_Project
{
    partial class FrmBossLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBossLevel));
            this.picElevator = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picElevator
            // 
            this.picElevator.Image = ((System.Drawing.Image)(resources.GetObject("picElevator.Image")));
            this.picElevator.Location = new System.Drawing.Point(0, 0);
            this.picElevator.Name = "picElevator";
            this.picElevator.Size = new System.Drawing.Size(137, 158);
            this.picElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElevator.TabIndex = 25;
            this.picElevator.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(22, 166);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(81, 115);
            this.picPlayer.TabIndex = 26;
            this.picPlayer.TabStop = false;
            // 
            // FrmBossLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(1034, 559);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picElevator);
            this.Name = "FrmBossLevel";
            this.Text = "BossLevel";
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picElevator;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}
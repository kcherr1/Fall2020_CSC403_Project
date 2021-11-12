
namespace Fall2020_CSC403_Project
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonChangeDifficulty = new System.Windows.Forms.Button();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.imageListDifficulties = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDifficulties = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDifficulties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.Location = new System.Drawing.Point(192, 407);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(560, 85);
            this.buttonStartGame.TabIndex = 3;
            this.buttonStartGame.Text = "Start Game!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonChangeDifficulty
            // 
            this.buttonChangeDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeDifficulty.Location = new System.Drawing.Point(192, 561);
            this.buttonChangeDifficulty.Name = "buttonChangeDifficulty";
            this.buttonChangeDifficulty.Size = new System.Drawing.Size(560, 85);
            this.buttonChangeDifficulty.TabIndex = 4;
            this.buttonChangeDifficulty.Text = "Change Difficulty";
            this.buttonChangeDifficulty.UseVisualStyleBackColor = true;
            this.buttonChangeDifficulty.Click += new System.EventHandler(this.buttonChangeDifficulty_Click);
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.Image = global::Fall2020_CSC403_Project.Properties.Resources.boxart;
            this.pictureBoxArt.Location = new System.Drawing.Point(983, 12);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(558, 860);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArt.TabIndex = 1;
            this.pictureBoxArt.TabStop = false;
            // 
            // imageListDifficulties
            // 
            this.imageListDifficulties.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDifficulties.ImageStream")));
            this.imageListDifficulties.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDifficulties.Images.SetKeyName(0, "creamy.png");
            this.imageListDifficulties.Images.SetKeyName(1, "crunchy.png");
            this.imageListDifficulties.Images.SetKeyName(2, "nutty.png");
            // 
            // pictureBoxDifficulties
            // 
            this.pictureBoxDifficulties.Image = global::Fall2020_CSC403_Project.Properties.Resources.creamy;
            this.pictureBoxDifficulties.Location = new System.Drawing.Point(192, 701);
            this.pictureBoxDifficulties.Name = "pictureBoxDifficulties";
            this.pictureBoxDifficulties.Size = new System.Drawing.Size(561, 150);
            this.pictureBoxDifficulties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDifficulties.TabIndex = 5;
            this.pictureBoxDifficulties.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "NullPointerException Games Presents...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 169);
            this.label2.TabIndex = 7;
            this.label2.Text = "Game Title!";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1586, 924);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDifficulties);
            this.Controls.Add(this.buttonChangeDifficulty);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.pictureBoxArt);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDifficulties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonChangeDifficulty;
        private System.Windows.Forms.ImageList imageListDifficulties;
        private System.Windows.Forms.PictureBox pictureBoxDifficulties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
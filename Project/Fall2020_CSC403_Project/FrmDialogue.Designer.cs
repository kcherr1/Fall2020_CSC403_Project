namespace Fall2020_CSC403_Project
{
    partial class FrmDialogue
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(-42, -15);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(454, 510);
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(890, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picPlayer);
            this.Name = "FrmDialogue";
            this.Text = "FrmDialogue";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.PictureBox picCooler;

    }
}
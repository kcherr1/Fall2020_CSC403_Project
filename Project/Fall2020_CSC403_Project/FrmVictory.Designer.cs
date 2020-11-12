namespace Fall2020_CSC403_Project
{
    partial class FrmVictory
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
            this.EndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndGame
            // 
            this.EndGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGame.Location = new System.Drawing.Point(600, 375);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(206, 62);
            this.EndGame.TabIndex = 0;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.endGameClick);
            // 
            // FrmVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.victory_screen;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.EndGame);
            this.Name = "FrmVictory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Victory! :)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndGame;
    }
}
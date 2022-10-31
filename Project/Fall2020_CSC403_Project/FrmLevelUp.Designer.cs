namespace Fall2020_CSC403_Project
{
    partial class FrmLevelUp
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
            this.attackButton = new System.Windows.Forms.Button();
            this.defenseButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.PlayerLevel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.SystemColors.Control;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attackButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.attackButton.Location = new System.Drawing.Point(337, 156);
            this.attackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(200, 81);
            this.attackButton.TabIndex = 3;
            this.attackButton.Text = "Attack +";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // defenseButton
            // 
            this.defenseButton.BackColor = System.Drawing.SystemColors.Control;
            this.defenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.defenseButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.defenseButton.Location = new System.Drawing.Point(337, 245);
            this.defenseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defenseButton.Name = "defenseButton";
            this.defenseButton.Size = new System.Drawing.Size(200, 81);
            this.defenseButton.TabIndex = 4;
            this.defenseButton.Text = "Defense +\r";
            this.defenseButton.UseVisualStyleBackColor = false;
            this.defenseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // speedButton
            // 
            this.speedButton.BackColor = System.Drawing.SystemColors.Control;
            this.speedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.speedButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.speedButton.Location = new System.Drawing.Point(337, 334);
            this.speedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(200, 81);
            this.speedButton.TabIndex = 5;
            this.speedButton.Text = "Speed +";
            this.speedButton.UseVisualStyleBackColor = false;
            this.speedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.AutoSize = true;
            this.PlayerLevel.Location = new System.Drawing.Point(389, 94);
            this.PlayerLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(0, 16);
            this.PlayerLevel.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(377, 452);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 47);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(316, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "You have 5 skill points!";
            // 
            // FrmLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(895, 612);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.PlayerLevel);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.defenseButton);
            this.Controls.Add(this.attackButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLevelUp";
            this.Text = "FrmLevelUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button defenseButton;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Label PlayerLevel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace Fall2020_CSC403_Project
{
    partial class StatsMenu
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
            this.defenseValueLabel = new System.Windows.Forms.Label();
            this.evasionValueLabel = new System.Windows.Forms.Label();
            this.strengthValueLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.evasionLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addDefenseLabel = new System.Windows.Forms.Label();
            this.addEvasionLabel = new System.Windows.Forms.Label();
            this.addStrengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availablePointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defenseValueLabel
            // 
            this.defenseValueLabel.AutoSize = true;
            this.defenseValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseValueLabel.Location = new System.Drawing.Point(153, 284);
            this.defenseValueLabel.Name = "defenseValueLabel";
            this.defenseValueLabel.Size = new System.Drawing.Size(51, 20);
            this.defenseValueLabel.TabIndex = 0;
            this.defenseValueLabel.Text = "label1";
            // 
            // evasionValueLabel
            // 
            this.evasionValueLabel.AutoSize = true;
            this.evasionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evasionValueLabel.Location = new System.Drawing.Point(153, 194);
            this.evasionValueLabel.Name = "evasionValueLabel";
            this.evasionValueLabel.Size = new System.Drawing.Size(51, 20);
            this.evasionValueLabel.TabIndex = 1;
            this.evasionValueLabel.Text = "label2";
            // 
            // strengthValueLabel
            // 
            this.strengthValueLabel.AutoSize = true;
            this.strengthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthValueLabel.Location = new System.Drawing.Point(153, 110);
            this.strengthValueLabel.Name = "strengthValueLabel";
            this.strengthValueLabel.Size = new System.Drawing.Size(51, 20);
            this.strengthValueLabel.TabIndex = 2;
            this.strengthValueLabel.Text = "label3";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.Location = new System.Drawing.Point(66, 110);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(71, 20);
            this.strengthLabel.TabIndex = 6;
            this.strengthLabel.Text = "Strength";
            // 
            // evasionLabel
            // 
            this.evasionLabel.AutoSize = true;
            this.evasionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evasionLabel.Location = new System.Drawing.Point(66, 194);
            this.evasionLabel.Name = "evasionLabel";
            this.evasionLabel.Size = new System.Drawing.Size(65, 20);
            this.evasionLabel.TabIndex = 7;
            this.evasionLabel.Text = "Evasion";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseLabel.Location = new System.Drawing.Point(66, 284);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(70, 20);
            this.defenseLabel.TabIndex = 8;
            this.defenseLabel.Text = "Defense";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 31);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Stats";
            // 
            // addDefenseLabel
            // 
            this.addDefenseLabel.AutoSize = true;
            this.addDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDefenseLabel.Location = new System.Drawing.Point(230, 280);
            this.addDefenseLabel.Name = "addDefenseLabel";
            this.addDefenseLabel.Size = new System.Drawing.Size(25, 26);
            this.addDefenseLabel.TabIndex = 10;
            this.addDefenseLabel.Text = "+";
            this.addDefenseLabel.Click += new System.EventHandler(this.AddDefenseLabel_Click);
            // 
            // addEvasionLabel
            // 
            this.addEvasionLabel.AutoSize = true;
            this.addEvasionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvasionLabel.Location = new System.Drawing.Point(230, 190);
            this.addEvasionLabel.Name = "addEvasionLabel";
            this.addEvasionLabel.Size = new System.Drawing.Size(25, 26);
            this.addEvasionLabel.TabIndex = 11;
            this.addEvasionLabel.Text = "+";
            this.addEvasionLabel.Click += new System.EventHandler(this.AddEvasionLabel_Click);
            // 
            // addStrengthLabel
            // 
            this.addStrengthLabel.AutoSize = true;
            this.addStrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStrengthLabel.Location = new System.Drawing.Point(230, 106);
            this.addStrengthLabel.Name = "addStrengthLabel";
            this.addStrengthLabel.Size = new System.Drawing.Size(25, 26);
            this.addStrengthLabel.TabIndex = 12;
            this.addStrengthLabel.Text = "+";
            this.addStrengthLabel.Click += new System.EventHandler(this.AddStrengthLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Available Points: ";
            // 
            // availablePointsLabel
            // 
            this.availablePointsLabel.AutoSize = true;
            this.availablePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePointsLabel.Location = new System.Drawing.Point(172, 62);
            this.availablePointsLabel.Name = "availablePointsLabel";
            this.availablePointsLabel.Size = new System.Drawing.Size(20, 24);
            this.availablePointsLabel.TabIndex = 15;
            this.availablePointsLabel.Text = "0";
            // 
            // StatsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.availablePointsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStrengthLabel);
            this.Controls.Add(this.addEvasionLabel);
            this.Controls.Add(this.addDefenseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.evasionLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.strengthValueLabel);
            this.Controls.Add(this.evasionValueLabel);
            this.Controls.Add(this.defenseValueLabel);
            this.Name = "StatsMenu";
            this.Text = "StatsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label defenseValueLabel;
        private System.Windows.Forms.Label evasionValueLabel;
        private System.Windows.Forms.Label strengthValueLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label evasionLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addDefenseLabel;
        private System.Windows.Forms.Label addEvasionLabel;
        private System.Windows.Forms.Label addStrengthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availablePointsLabel;
    }
}
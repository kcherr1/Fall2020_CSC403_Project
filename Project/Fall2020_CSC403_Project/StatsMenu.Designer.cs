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
            this.addStrengthButton = new System.Windows.Forms.Button();
            this.addEvasionButton = new System.Windows.Forms.Button();
            this.addDefenseButton = new System.Windows.Forms.Button();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.evasionLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
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
            // addStrengthButton
            // 
            this.addStrengthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStrengthButton.Location = new System.Drawing.Point(238, 109);
            this.addStrengthButton.Name = "addStrengthButton";
            this.addStrengthButton.Size = new System.Drawing.Size(23, 23);
            this.addStrengthButton.TabIndex = 3;
            this.addStrengthButton.Text = "+";
            this.addStrengthButton.UseVisualStyleBackColor = true;
            this.addStrengthButton.Click += new System.EventHandler(this.AddStrengthButton_Click);
            // 
            // addEvasionButton
            // 
            this.addEvasionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvasionButton.Location = new System.Drawing.Point(238, 189);
            this.addEvasionButton.Name = "addEvasionButton";
            this.addEvasionButton.Size = new System.Drawing.Size(23, 23);
            this.addEvasionButton.TabIndex = 4;
            this.addEvasionButton.Text = "+";
            this.addEvasionButton.UseVisualStyleBackColor = true;
            this.addEvasionButton.Click += new System.EventHandler(this.AddEvasionButton_Click);
            // 
            // addDefenseButton
            // 
            this.addDefenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDefenseButton.Location = new System.Drawing.Point(238, 279);
            this.addDefenseButton.Name = "addDefenseButton";
            this.addDefenseButton.Size = new System.Drawing.Size(23, 23);
            this.addDefenseButton.TabIndex = 5;
            this.addDefenseButton.Text = "+";
            this.addDefenseButton.UseVisualStyleBackColor = true;
            this.addDefenseButton.Click += new System.EventHandler(this.AddDefenseButton_Click);
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
            // StatsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.evasionLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.addDefenseButton);
            this.Controls.Add(this.addEvasionButton);
            this.Controls.Add(this.addStrengthButton);
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
        private System.Windows.Forms.Button addStrengthButton;
        private System.Windows.Forms.Button addEvasionButton;
        private System.Windows.Forms.Button addDefenseButton;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label evasionLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
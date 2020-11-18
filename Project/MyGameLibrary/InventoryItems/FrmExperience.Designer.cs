namespace Fall2020_CSC403_Project
{
    partial class FrmExperience
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
            this.ExperienceLabel = new System.Windows.Forms.Label();
            this.AllocatedExperience = new System.Windows.Forms.NumericUpDown();
            this.rBtnAttack = new System.Windows.Forms.RadioButton();
            this.rBtnDefence = new System.Windows.Forms.RadioButton();
            this.ExperienceDisplay = new System.Windows.Forms.Label();
            this.ApplyExperience = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // ExperienceLabel
            // 
            this.ExperienceLabel.AutoSize = true;
            this.ExperienceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExperienceLabel.Location = new System.Drawing.Point(13, 13);
            this.ExperienceLabel.Name = "ExperienceLabel";
            this.ExperienceLabel.Size = new System.Drawing.Size(69, 13);
            this.ExperienceLabel.TabIndex = 2;
            this.ExperienceLabel.Text = "Experience : ";
            this.ExperienceLabel.UseWaitCursor = true;
            // 
            // AllocatedExperience
            // 
            this.AllocatedExperience.Location = new System.Drawing.Point(12, 36);
            this.AllocatedExperience.Name = "AllocatedExperience";
            this.AllocatedExperience.Size = new System.Drawing.Size(120, 20);
            this.AllocatedExperience.TabIndex = 3;
            this.AllocatedExperience.ValueChanged += new System.EventHandler(this.AllocatedExperience_ValueChanged);
            // 
            // rBtnAttack
            // 
            this.rBtnAttack.AutoSize = true;
            this.rBtnAttack.Location = new System.Drawing.Point(155, 13);
            this.rBtnAttack.Name = "rBtnAttack";
            this.rBtnAttack.Size = new System.Drawing.Size(56, 17);
            this.rBtnAttack.TabIndex = 4;
            this.rBtnAttack.TabStop = true;
            this.rBtnAttack.Text = "Attack";
            this.rBtnAttack.UseVisualStyleBackColor = true;
            this.rBtnAttack.CheckedChanged += new System.EventHandler(this.rBtnAttack_CheckedChanged);
            // 
            // rBtnDefence
            // 
            this.rBtnDefence.AutoSize = true;
            this.rBtnDefence.Location = new System.Drawing.Point(155, 36);
            this.rBtnDefence.Name = "rBtnDefence";
            this.rBtnDefence.Size = new System.Drawing.Size(66, 17);
            this.rBtnDefence.TabIndex = 5;
            this.rBtnDefence.TabStop = true;
            this.rBtnDefence.Text = "Defence";
            this.rBtnDefence.UseVisualStyleBackColor = true;
            this.rBtnDefence.CheckedChanged += new System.EventHandler(this.rBtnDefence_CheckedChanged);
            // 
            // ExperienceDisplay
            // 
            this.ExperienceDisplay.AutoSize = true;
            this.ExperienceDisplay.Location = new System.Drawing.Point(77, 13);
            this.ExperienceDisplay.Name = "ExperienceDisplay";
            this.ExperienceDisplay.Size = new System.Drawing.Size(0, 13);
            this.ExperienceDisplay.TabIndex = 6;
            // 
            // ApplyExperience
            // 
            this.ApplyExperience.Location = new System.Drawing.Point(80, 73);
            this.ApplyExperience.Name = "ApplyExperience";
            this.ApplyExperience.Size = new System.Drawing.Size(75, 23);
            this.ApplyExperience.TabIndex = 7;
            this.ApplyExperience.Text = "Apply";
            this.ApplyExperience.UseVisualStyleBackColor = true;
            this.ApplyExperience.Click += new System.EventHandler(this.ApplyExperience_Click);
            // 
            // FrmExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 104);
            this.Controls.Add(this.ApplyExperience);
            this.Controls.Add(this.ExperienceDisplay);
            this.Controls.Add(this.rBtnDefence);
            this.Controls.Add(this.rBtnAttack);
            this.Controls.Add(this.AllocatedExperience);
            this.Controls.Add(this.ExperienceLabel);
            this.Name = "FrmExperience";
            this.Text = "Use Experience";
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExperienceLabel;
        private System.Windows.Forms.NumericUpDown AllocatedExperience;
        private System.Windows.Forms.RadioButton rBtnAttack;
        private System.Windows.Forms.RadioButton rBtnDefence;
        private System.Windows.Forms.Label ExperienceDisplay;
        private System.Windows.Forms.Button ApplyExperience;
    }
}
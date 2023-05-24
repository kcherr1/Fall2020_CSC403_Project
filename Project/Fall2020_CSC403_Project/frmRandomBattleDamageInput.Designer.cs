namespace Fall2020_CSC403_Project
{
    partial class frmRandomBattleDamageInput
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
            this.txtMinumumDamage = new System.Windows.Forms.TextBox();
            this.txtMaximumDamage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMinumumDamage
            // 
            this.txtMinumumDamage.Location = new System.Drawing.Point(302, 236);
            this.txtMinumumDamage.Name = "txtMinumumDamage";
            this.txtMinumumDamage.Size = new System.Drawing.Size(100, 38);
            this.txtMinumumDamage.TabIndex = 0;
            // 
            // txtMaximumDamage
            // 
            this.txtMaximumDamage.Location = new System.Drawing.Point(660, 236);
            this.txtMaximumDamage.Name = "txtMaximumDamage";
            this.txtMaximumDamage.Size = new System.Drawing.Size(100, 38);
            this.txtMaximumDamage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum Damage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum Damage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1051, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "This form allows us to set the minimum and maximum damage dealt during battle.  \r" +
    "\nA random integer will be generated between these two values during battles!";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(302, 347);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(148, 47);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(612, 347);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(148, 47);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRandomBattleDamageInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1136, 503);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaximumDamage);
            this.Controls.Add(this.txtMinumumDamage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRandomBattleDamageInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRandomBattleDamageInput";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmRandomBattleDamageInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinumumDamage;
        private System.Windows.Forms.TextBox txtMaximumDamage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
    }
}
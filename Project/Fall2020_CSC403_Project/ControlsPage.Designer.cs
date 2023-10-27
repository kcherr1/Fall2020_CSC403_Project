namespace Fall2020_CSC403_Project
{
    partial class ControlsPage
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
            this.lblControl1 = new System.Windows.Forms.Label();
            this.btnCloseControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblControl1
            // 
            this.lblControl1.AutoSize = true;
            this.lblControl1.Location = new System.Drawing.Point(285, 106);
            this.lblControl1.Name = "lblControl1";
            this.lblControl1.Size = new System.Drawing.Size(229, 20);
            this.lblControl1.TabIndex = 0;
            this.lblControl1.Text = "P: Brings up the Settings Page.";
            // 
            // btnCloseControls
            // 
            this.btnCloseControls.Location = new System.Drawing.Point(333, 274);
            this.btnCloseControls.Name = "btnCloseControls";
            this.btnCloseControls.Size = new System.Drawing.Size(114, 51);
            this.btnCloseControls.TabIndex = 1;
            this.btnCloseControls.Text = "Close";
            this.btnCloseControls.UseVisualStyleBackColor = true;
            this.btnCloseControls.Click += new System.EventHandler(this.btnCloseControls_Click);
            // 
            // ControlsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseControls);
            this.Controls.Add(this.lblControl1);
            this.Name = "ControlsPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControl1;
        private System.Windows.Forms.Button btnCloseControls;
    }
}
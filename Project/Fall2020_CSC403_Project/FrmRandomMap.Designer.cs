namespace Fall2020_CSC403_Project
{
    partial class FrmRandomMap
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
            this.picWallTemplate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTemplate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWallTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // picWallTemplate
            // 
            this.picWallTemplate.BackColor = System.Drawing.Color.Transparent;
            this.picWallTemplate.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWallTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWallTemplate.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.InitialImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWallTemplate.Location = new System.Drawing.Point(0, 0);
            this.picWallTemplate.Name = "picWallTemplate";
            this.picWallTemplate.Size = new System.Drawing.Size(50, 50);
            this.picWallTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWallTemplate.TabIndex = 11;
            this.picWallTemplate.TabStop = false;
            this.picWallTemplate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // txtBoxTemplate
            // 
            this.txtBoxTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTemplate.Location = new System.Drawing.Point(518, 330);
            this.txtBoxTemplate.Multiline = true;
            this.txtBoxTemplate.Name = "txtBoxTemplate";
            this.txtBoxTemplate.Size = new System.Drawing.Size(50, 50);
            this.txtBoxTemplate.TabIndex = 13;
            this.txtBoxTemplate.Visible = false;
            // 
            // FrmRandomMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1210, 738);
            this.Controls.Add(this.txtBoxTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWallTemplate);
            this.Name = "FrmRandomMap";
            this.Text = "FrmRandomMap";
            this.Load += new System.EventHandler(this.FrmRandomMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWallTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWallTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTemplate;
    }
}
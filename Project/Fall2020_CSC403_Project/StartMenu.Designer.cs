namespace Fall2020_CSC403_Project
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_game_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_game_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.new_game_btn);
            this.panel1.Location = new System.Drawing.Point(87, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 651);
            this.panel1.TabIndex = 0;
            // 
            // new_game_btn
            // 
            this.new_game_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_game_btn.Image")));
            this.new_game_btn.Location = new System.Drawing.Point(303, 212);
            this.new_game_btn.Name = "new_game_btn";
            this.new_game_btn.Size = new System.Drawing.Size(309, 112);
            this.new_game_btn.TabIndex = 0;
            this.new_game_btn.TabStop = false;
            this.new_game_btn.Click += new System.EventHandler(this.new_game_btn_Click);
            this.new_game_btn.MouseHover += new System.EventHandler(this.new_game_btn_MouseHover);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.panel1);
            this.Name = "StartMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.new_game_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox new_game_btn;
    }
}
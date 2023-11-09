namespace Fall2020_CSC403_Project
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.playBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelHome = new System.Windows.Forms.Label();
            this.picHealthPotion0 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHealthPotion0)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(875, 26);
            this.playBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(233, 72);
            this.playBtn.TabIndex = 0;
            this.playBtn.TabStop = false;
            this.playBtn.Text = "New Game";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1426, 26);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(233, 72);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(14, 11);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(503, 122);
            this.labelHome.TabIndex = 4;
            this.labelHome.Text = "Welcome!";
            // 
            // picHealthPotion0
            // 
            this.picHealthPotion0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.home;
            this.picHealthPotion0.Location = new System.Drawing.Point(709, 254);
            this.picHealthPotion0.Name = "picHealthPotion0";
            this.picHealthPotion0.Size = new System.Drawing.Size(477, 381);
            this.picHealthPotion0.TabIndex = 5;
            this.picHealthPotion0.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::Fall2020_CSC403_Project.Properties.Resources.home;
            this.label1.Location = new System.Drawing.Point(663, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(519, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1159, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "Instruction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1671, 798);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHealthPotion0);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picHealthPotion0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.PictureBox picHealthPotion0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}
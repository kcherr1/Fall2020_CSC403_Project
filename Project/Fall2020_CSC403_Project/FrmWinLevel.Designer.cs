namespace Fall2020_CSC403_Project
{
    partial class FrmWinLevel
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
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(377, 413);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(192, 87);
      this.button1.TabIndex = 0;
      this.button1.Text = "Continue...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // pictureBox3
      // 
      this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox3.Image = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid_xded;
      this.pictureBox3.Location = new System.Drawing.Point(297, 50);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(361, 246);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 5;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox2.Image = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
      this.pictureBox2.Location = new System.Drawing.Point(297, 50);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(361, 246);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(189, 331);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(574, 58);
      this.label1.TabIndex = 6;
      this.label1.Text = "Yippee! You straight up drank the Kool-Aid man! \r\nNow you can enter the portal to" +
    " move to the next level!\r\n";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // FrmWinLevel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.CornflowerBlue;
      this.ClientSize = new System.Drawing.Size(978, 549);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox2);
      this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximumSize = new System.Drawing.Size(1000, 605);
      this.Name = "FrmWinLevel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Victory!";
      this.Load += new System.EventHandler(this.FrmWinLevel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource bindingSource1;
  }
}
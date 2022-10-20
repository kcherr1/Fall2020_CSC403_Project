namespace Fall2020_CSC403_Project
{
  partial class FrmPause
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
      this.btnResume = new System.Windows.Forms.Button();
      this.btnRestart = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnResume
      // 
      this.btnResume.Location = new System.Drawing.Point(320, 54);
      this.btnResume.Name = "btnResume";
      this.btnResume.Size = new System.Drawing.Size(166, 95);
      this.btnResume.TabIndex = 0;
      this.btnResume.Text = "RESUME";
      this.btnResume.UseVisualStyleBackColor = true;
      this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
      // 
      // btnRestart
      // 
      this.btnRestart.Location = new System.Drawing.Point(320, 177);
      this.btnRestart.Name = "btnRestart";
      this.btnRestart.Size = new System.Drawing.Size(166, 95);
      this.btnRestart.TabIndex = 1;
      this.btnRestart.Text = "RESTART";
      this.btnRestart.UseVisualStyleBackColor = true;
      this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Location = new System.Drawing.Point(320, 301);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(166, 95);
      this.btnQuit.TabIndex = 2;
      this.btnQuit.Text = "QUIT";
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // FrmPause
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnRestart);
      this.Controls.Add(this.btnResume);
      this.Name = "FrmPause";
      this.Text = "FrmPause";
      this.Load += new System.EventHandler(this.FrmPause_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnResume;
    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.Button btnQuit;
  }
}
namespace Fall2020_CSC403_Project
{
  partial class FrmPlayerDeath
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.button1.Location = new System.Drawing.Point(166, 433);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(379, 217);
      this.button1.TabIndex = 0;
      this.button1.Text = "Yes";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.button2.Location = new System.Drawing.Point(729, 433);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(379, 217);
      this.button2.TabIndex = 1;
      this.button2.Text = "No";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(443, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(372, 91);
      this.label1.TabIndex = 2;
      this.label1.Text = "You Died";
      this.label1.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(114, 217);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(1054, 91);
      this.label2.TabIndex = 3;
      this.label2.Text = "Would You Like To Restart?";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // FrmPlayerDeath
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.Red;
      this.ClientSize = new System.Drawing.Size(1263, 772);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "FrmPlayerDeath";
      this.Text = "You Died :(";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}
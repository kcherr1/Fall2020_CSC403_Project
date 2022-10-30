using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmDeath : Form
    {
        private Button Try_Again;
        private Button Quit;
        public static FrmDeath instance = null;

        private FrmDeath()
        {
            InitializeComponent();
        }

        public static FrmDeath GetInstance()
        {
            instance = new FrmDeath();
            return instance;
        }

        private void InitializeComponent()
        {
            this.Try_Again = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Try_Again
            // 
            this.Try_Again.Location = new System.Drawing.Point(158, 333);
            this.Try_Again.Name = "Try_Again";
            this.Try_Again.Size = new System.Drawing.Size(120, 45);
            this.Try_Again.TabIndex = 0;
            this.Try_Again.Text = "Try Again";
            this.Try_Again.UseVisualStyleBackColor = true;
            this.Try_Again.Click += new System.EventHandler(this.Try_Again_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(499, 333);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(120, 45);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // FrmDeath
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Try_Again);
            this.Name = "FrmDeath";
            this.ResumeLayout(false);

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Try_Again_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}


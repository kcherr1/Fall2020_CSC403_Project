using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmDeath : Form
    {
        private Button Try_Again;
        private Button Quit;
        private Label label1;
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Try_Again
            // 
            this.Try_Again.BackColor = System.Drawing.Color.MidnightBlue;
            this.Try_Again.ForeColor = System.Drawing.SystemColors.Menu;
            this.Try_Again.Location = new System.Drawing.Point(122, 249);
            this.Try_Again.Name = "Try_Again";
            this.Try_Again.Size = new System.Drawing.Size(120, 45);
            this.Try_Again.TabIndex = 0;
            this.Try_Again.Text = "Try Again (you loser)";
            this.Try_Again.UseVisualStyleBackColor = false;
            this.Try_Again.Click += new System.EventHandler(this.Try_Again_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.MidnightBlue;
            this.Quit.ForeColor = System.Drawing.SystemColors.Menu;
            this.Quit.Location = new System.Drawing.Point(341, 249);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(120, 45);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit (you pansy)";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 160);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOU SUCK! \r\nGAME OVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDeath
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Try_Again);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FrmDeath";
            this.Text = "The Winner\'s Circle (SIKE!)";
            this.ResumeLayout(false);
            this.PerformLayout();

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


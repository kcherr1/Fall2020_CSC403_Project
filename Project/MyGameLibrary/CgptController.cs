using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using OpenAI_API;


namespace Fall2020_CSC403_Project
{
    public class TextBoxer : Form
    {
        public TextBox textBox1;
        public TextBoxer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Multiline = true;
            //this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textBox1);
            this.Text = "this isnt text";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    public class CGPT
    {
        public void InitializeCGPT()
        {
            /*
             var openAi = new OpenAIAPI("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");

             var completions = openAi.Completions.CreateCompletionAsync(
                prompt: "What is the meaning of life?",
                model: "text-davinci-002",
                max_tokens: 20,
                temperature: 0.5f
                );
            */

        }
    }
}


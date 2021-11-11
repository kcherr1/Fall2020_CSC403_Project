using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyGameLibrary.Story;
using MyGameLibrary.UI;

namespace Fall2020_CSC403_Project
{
    partial class TextEngine
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

        /// This function override is taken from https://stackoverflow.com/questions/2612487/how-to-fix-the-flickering-in-user-controls/2613272
        /// The goal is to stop the "black flickering" on adding controls as well as resizing
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEngine));
            this.ForegroundImage = new System.Windows.Forms.PictureBox();
            this.Textbox = new MyGameLibrary.UI.GradientTextbox();
            this.NormalPanel = new DoubleBufferedPanel();
            this.OptionsPanel = new DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ForegroundImage)).BeginInit();
            this.NormalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForegroundImage
            // 
            this.ForegroundImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForegroundImage.BackColor = System.Drawing.Color.Transparent;
            this.ForegroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForegroundImage.BackgroundImage")));
            this.ForegroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForegroundImage.Location = new System.Drawing.Point(463, -8);
            this.ForegroundImage.Name = "ForegroundImage";
            this.ForegroundImage.Size = new System.Drawing.Size(243, 404);
            this.ForegroundImage.TabIndex = 6;
            this.ForegroundImage.TabStop = false;
            // 
            // Textbox
            // 
            this.Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Textbox.Font = new System.Drawing.Font("Verdana Pro", 12F);
            this.Textbox.Location = new System.Drawing.Point(0, 350);
            this.Textbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Textbox.Name = "Textbox";
            this.Textbox.Text = "";
            this.Textbox.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.Textbox.Size = new System.Drawing.Size(800, 100);
            this.Textbox.TabIndex = 7;
            //this.Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NormalPanel
            // 
            this.NormalPanel.AutoSize = true;
            this.NormalPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NormalPanel.BackgroundImage")));
            this.NormalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NormalPanel.Controls.Add(this.Textbox);
            this.NormalPanel.Controls.Add(this.ForegroundImage);
            this.NormalPanel.Dock = System.Windows.Forms.DockStyle.Fill;            
            this.NormalPanel.Location = new System.Drawing.Point(0, 0);
            this.NormalPanel.Name = "NormalPanel";
            this.NormalPanel.Size = new System.Drawing.Size(800, 450);
            this.NormalPanel.TabIndex = 6;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.AutoSize = true;
            this.OptionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionsPanel.BackgroundImage")));
            this.OptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(800, 450);
            this.OptionsPanel.TabIndex = 6;
            this.OptionsPanel.Visible = false;
            // 
            // TextEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.NormalPanel);
            this.DoubleBuffered = true;
            this.Name = "TextEngine";
            this.Text = "Mr. Peanut Finds Love";
            this.Load += new System.EventHandler(this.TextEngine_Load_1);
            this.ClientSizeChanged += new System.EventHandler(this.ResizeHandler);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEngine_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ForegroundImage)).EndInit();
            this.NormalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            // set original values for resizing
            this.originalHeight = Height;
            this.originalWidth = Width;
            this.ForegroundImage_Xscale = (double)ForegroundImage.Left / Width;
            this.ForegroundImage_Yscale = (double)ForegroundImage.Top / Height;
            this.ForegroundImage_AspectRatio = ForegroundImage.Size.Width / (ForegroundImage.Size.Height * 1.0);

            BalanceLabel.Location = new Point(ClientRectangle.Width-70, 0);
        }
        #endregion

        private System.Windows.Forms.PictureBox ForegroundImage;
        private System.Windows.Forms.Panel NormalPanel;
        private System.Windows.Forms.Panel OptionsPanel;

        private GradientTextbox BalanceLabel = new GradientTextbox {
            AutoSize = false,
            Size = new Size(70, 30),
            TextAlign = ContentAlignment.TopRight,
            Text = Inventory.walletBalance.ToString(),
            Font = new Font("Verdana Pro", 16),
        };
        
        
        private void UpdateBalance(bool BalDisplayed) {
            if (BalDisplayed == false) {
                this.Controls.Remove(BalanceLabel);
            }
            else {
                BalanceLabel.Text = Inventory.walletBalance.ToString();
                this.Controls.Add(BalanceLabel);
                BalanceLabel.BringToFront();
            }
        }
        private void DisplayOptions(List<Option> options)
        {
            System.Drawing.Point location = new System.Drawing.Point(20, 50);
            this.NormalPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            this.OptionsPanel.Controls.Add(this.Textbox);
            this.OptionsPanel.Controls.Add(this.ForegroundImage);

            //maintain scaling - resize handler only resizes current options, new options must be resized on creation
            double heightScaling = Height / (double)originalHeight;
            double widthScaling = Width / (double)originalWidth;
            foreach (Option option in options)
            {
                //
                // Option Label
                //
                var optionLabel = new System.Windows.Forms.Label();
                // Properties
                optionLabel.BackColor = Color.AntiqueWhite;
                optionLabel.BorderStyle = BorderStyle.FixedSingle;
                optionLabel.Location = location;
                optionLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
                optionLabel.Size = new System.Drawing.Size((int)(150*widthScaling), (int)(25*heightScaling));
                optionLabel.Font = new Font("Calibri", (int)(heightScaling * 8));
                optionLabel.Text = option.OptionText;
                option.OptionLabel = optionLabel; // Set the associated label control in the option object for ease of delete
                if (options.Count >= 6 && option.Equals(options[5]))
                {
                    location =  new Point(40 + optionLabel.Width, 50);
                }
                else
                {
                    location.Offset(0, (int)(40*heightScaling));
                }
                //this.NormalPanel.Controls.Add(optionLabel); // Add option to the panel
                this.OptionsPanel.Controls.Add(optionLabel); // Add option to the panel
               //location.Offset(0, 20); // Next option will be slightly lower
            }
            Console.WriteLine(this.OptionsPanel.Controls);
            this.OptionsPanel.Visible = true;
            this.NormalPanel.Visible = false;
            this.NormalPanel.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void RemoveOptions(List<Option> options) 
        {
            this.NormalPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            this.NormalPanel.Controls.Add(this.Textbox);
            this.NormalPanel.Controls.Add(this.ForegroundImage);
            //this.OptionsPanel.Controls[1].Location = new Point((int)(ForegroundImage_Xscale * ClientRectangle.Size.Width), (int)(ForegroundImage_Yscale * Height));
            this.NormalPanel.Visible = true;
            this.OptionsPanel.Visible = false;
            foreach (Option option in options)
            {
                this.OptionsPanel.Controls.Remove(option.OptionLabel);
            }
            Console.WriteLine(this.OptionsPanel.Controls);
            this.NormalPanel.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private GradientTextbox Textbox;
    }
}
using System.Collections.Generic;
using System.Drawing;
using MyGameLibrary.Story;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEngine));
            this.ForegroundImage = new System.Windows.Forms.PictureBox();
            this.Textbox = new System.Windows.Forms.Label();
            this.NormalPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ForegroundImage)).BeginInit();
            this.NormalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForegroundImage
            // 
            this.ForegroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Textbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Textbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Textbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Textbox.Location = new System.Drawing.Point(0, 350);
            this.Textbox.Margin = new System.Windows.Forms.Padding(3, 500, 3, 0);
            this.Textbox.Name = "Textbox";
            this.Textbox.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.Textbox.Size = new System.Drawing.Size(800, 100);
            this.Textbox.TabIndex = 7;
            this.Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // TextEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NormalPanel);
            this.DoubleBuffered = true;
            this.Name = "TextEngine";
            this.Text = "Mr. Peanut Finds Love";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEngine_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ForegroundImage)).EndInit();
            this.NormalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox ForegroundImage;
        private System.Windows.Forms.Label Textbox;
        private System.Windows.Forms.Panel NormalPanel;

        private void DisplayOptions(List<Option> options)
        {
            System.Drawing.Point location = new System.Drawing.Point(50, 50);
            this.NormalPanel.SuspendLayout();
            this.SuspendLayout();
            foreach (Option option in options)
            {
                //
                // Option Label
                //
                var optionLabel = new System.Windows.Forms.Label();
                // Properties
                optionLabel.BackColor = Color.AliceBlue;
                optionLabel.Location = location;
                optionLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
                optionLabel.Size = new System.Drawing.Size(150, 25);
                optionLabel.Text = option.OptionText;
                // 
                option.OptionLabel = optionLabel; // Set the associated label control in the option object for ease of delete
                this.NormalPanel.Controls.Add(optionLabel); // Add option to the panel
                location.Offset(0, 40); // Next option will be slightly lower
            }
            this.NormalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void RemoveOptions(List<Option> options) 
        {
            this.NormalPanel.SuspendLayout();
            this.SuspendLayout();
            foreach(Option option in options)
            {
                this.NormalPanel.Controls.Remove(option.OptionLabel);
            }
            this.NormalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
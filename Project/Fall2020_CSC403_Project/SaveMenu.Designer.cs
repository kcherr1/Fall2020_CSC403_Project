﻿namespace Fall2020_CSC403_Project
{
    partial class SaveMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Leave_SaveMenu = new System.Windows.Forms.Button();
            this.Load_Save_btn = new System.Windows.Forms.Button();
            this.New_Save_btn = new System.Windows.Forms.Button();
            this.SaveMenu_table = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SaveMenu_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(747, 398);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Leave_SaveMenu);
            this.panel1.Controls.Add(this.Load_Save_btn);
            this.panel1.Controls.Add(this.New_Save_btn);
            this.panel1.Controls.Add(this.SaveMenu_table);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 390);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Leave_SaveMenu
            // 
            this.Leave_SaveMenu.Font = new System.Drawing.Font("Forte", 21.75F);
            this.Leave_SaveMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Leave_SaveMenu.Location = new System.Drawing.Point(448, 334);
            this.Leave_SaveMenu.Name = "Leave_SaveMenu";
            this.Leave_SaveMenu.Size = new System.Drawing.Size(161, 41);
            this.Leave_SaveMenu.TabIndex = 4;
            this.Leave_SaveMenu.Text = "Leave";
            this.Leave_SaveMenu.UseVisualStyleBackColor = true;
            this.Leave_SaveMenu.Click += new System.EventHandler(this.Leave_SaveMenu_Click);
            // 
            // Load_Save_btn
            // 
            this.Load_Save_btn.Font = new System.Drawing.Font("Forte", 21.75F);
            this.Load_Save_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load_Save_btn.Location = new System.Drawing.Point(281, 334);
            this.Load_Save_btn.Name = "Load_Save_btn";
            this.Load_Save_btn.Size = new System.Drawing.Size(161, 41);
            this.Load_Save_btn.TabIndex = 3;
            this.Load_Save_btn.Text = "Load Save";
            this.Load_Save_btn.UseVisualStyleBackColor = true;
            this.Load_Save_btn.Click += new System.EventHandler(this.Load_Save_btn_Click);
            // 
            // New_Save_btn
            // 
            this.New_Save_btn.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Save_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.New_Save_btn.Location = new System.Drawing.Point(114, 334);
            this.New_Save_btn.Name = "New_Save_btn";
            this.New_Save_btn.Size = new System.Drawing.Size(161, 41);
            this.New_Save_btn.TabIndex = 2;
            this.New_Save_btn.Text = "New Save";
            this.New_Save_btn.UseVisualStyleBackColor = true;
            this.New_Save_btn.Click += new System.EventHandler(this.New_Save_btn_Click);
            // 
            // SaveMenu_table
            // 
            this.SaveMenu_table.ColumnCount = 1;
            this.SaveMenu_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SaveMenu_table.Controls.Add(this.button1, 0, 0);
            this.SaveMenu_table.Controls.Add(this.button2, 0, 1);
            this.SaveMenu_table.Controls.Add(this.button3, 0, 2);
            this.SaveMenu_table.Location = new System.Drawing.Point(114, 94);
            this.SaveMenu_table.Name = "SaveMenu_table";
            this.SaveMenu_table.RowCount = 3;
            this.SaveMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SaveMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SaveMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SaveMenu_table.Size = new System.Drawing.Size(494, 239);
            this.SaveMenu_table.TabIndex = 0;
            this.SaveMenu_table.Paint += new System.Windows.Forms.PaintEventHandler(this.SaveMenu_table_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Forte", 35F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveSlotButton1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Forte", 35F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(3, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(488, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveSlotButton2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Forte", 35F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(3, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(488, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveSlotButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.SaveMenuTitle;
            this.pictureBox1.Location = new System.Drawing.Point(114, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SaveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SaveMenu";
            this.Text = "SaveMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SaveMenu_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Leave_SaveMenu;
        private System.Windows.Forms.Button Load_Save_btn;
        private System.Windows.Forms.Button New_Save_btn;
        private System.Windows.Forms.TableLayoutPanel SaveMenu_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
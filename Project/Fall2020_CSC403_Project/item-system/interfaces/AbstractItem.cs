using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.item_system.interfaces
{
    public abstract class AbstractItem
    {
        public System.Windows.Forms.PictureBox picItem;
        public Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        public Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        public void InitializeComponent(FrmLevel frmLevel, int numItems, Image img, int locationX, int locationY, string name, int sizeX, int sizeY, int tabIndex)
        {
            picItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picItem)).BeginInit();
            frmLevel.SuspendLayout();
            //this.picItem.Image = global::Fall2020_CSC403_Project.Properties.Resources.RandomPotion;
            this.picItem.Image = img;
            //this.picItem.Location = new System.Drawing.Point(767, 354);
            this.picItem.Location = new System.Drawing.Point(locationX, locationY);
            //this.picItem.Name = "pictureBox1";
            this.picItem.Name = name + $"{numItems}";
            //this.picItem.Size = new System.Drawing.Size(50, 50);
            this.picItem.Size = new System.Drawing.Size(sizeX, sizeY);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            //this.picItem.TabIndex = 18;
            this.picItem.TabIndex = tabIndex;
            this.picItem.TabStop = false;
            frmLevel.Controls.Add(picItem);
            ((System.ComponentModel.ISupportInitialize)(picItem)).EndInit();
            frmLevel.ResumeLayout(false);
        }
    }
}

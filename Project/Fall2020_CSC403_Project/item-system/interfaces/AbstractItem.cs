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
        public System.Windows.Forms.PictureBox picEffectEvent;
        public Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        public Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        public void InitializeComponent(FrmLevel frmLevel, int numItems, Image img, float locationX, float locationY, string name, int sizeX, int sizeY, int tabIndex)
        {
            /*Parameters Example: 
             *  Image img --> this.picItem.Image = global::Fall2020_CSC403_Project.Properties.Resources.RandomPotion;
             *  float locationX --> 767
             *  float locationY --> 354
             *  string name --> this.picItem.Name = "pictureBox1";
             *  int sizeX --> 50
             *  int sizeY --> 50
             *  int tabIndex --> this.picItem.TabIndex = 18;
             */

            picItem = new System.Windows.Forms.PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(picItem)).BeginInit();
            frmLevel.SuspendLayout();
            
            this.picItem.Image = img;
            this.picItem.Location = new System.Drawing.Point(Convert.ToInt32(locationX), Convert.ToInt32(locationY));
            this.picItem.Name = name + $"{numItems}";
            this.picItem.Size = new System.Drawing.Size(sizeX, sizeY);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = tabIndex;
            this.picItem.TabStop = false;

            frmLevel.Controls.Add(picItem);
            ((System.ComponentModel.ISupportInitialize)(picItem)).EndInit();
            frmLevel.ResumeLayout(false);
        }
    }
}

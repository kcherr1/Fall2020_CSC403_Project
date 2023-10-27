using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        public static FrmInventory instance = null;
        public static PictureBox[] pictureBoxArray;
        private Inventory inventory;

        public void DisplayInventory(Inventory inventory)
        {
            List<Item> items = inventory.GetItems(); // Replace this with your actual method to get items            

            for (int i = 0; i < items.Count(); i++)
            {
                PictureBox slot = pictureBoxArray[11-i];
                Item item = items[i];

                slot.BackgroundImage = item.Img; 
                slot.Tag = item.Name.ToString();
                
            }
        }

        public FrmInventory(Inventory inventory)
        {
            InitializeComponent();
            this.Visible= true;
            this.KeyDown += FrmInventory_KeyDown;
            this.KeyPreview = true;

            // Add all PictureBox controls on the form to the pictureBoxSlots list
            pictureBoxArray = Controls.OfType<PictureBox>().ToArray();

            this.inventory = inventory;
            DisplayInventory(inventory);
        }

        private void FrmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    Hide();
                    break;
                case Keys.Escape:
                    Close();

                    break;
                case Keys.V:
                    invSlot1.BackgroundImage = this.inventory.GetItems()[0].Img;
                    break;
                default:
                    break;
            }
        }

        private void invSlot1_Click(object sender, EventArgs e)
        {
            if(invSlot1.Tag != null)
            {
                nameBox.Text = invSlot1.Tag.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static List<PictureBox> pictureBoxSlots = new List<PictureBox>();
        public static FrmInventory GetInstance(Inventory inventory)
        {
            if (instance == null)
            {
                instance = new FrmInventory();
                DisplayInventory(inventory);
                
            }
            return instance;
        }

        public static void DisplayInventory(Inventory inventory)
        {
            List<Item> items = inventory.GetItems(); // Replace this with your actual method to get items

            for (int i = 0; i < items.Count; i++)
            {
                PictureBox slot = pictureBoxSlots[i];
                Item item = items[i];

                if (slot != null && item != null)
                {
                    // Set the item's name as text and its image as the background for the slot
                    slot.Text = item.Name;
                    slot.BackgroundImage = item.Img;
                }
            }
        }

        public FrmInventory()
        {
            InitializeComponent();
            this.KeyDown += FrmInventory_KeyDown;
            this.KeyPreview = true;

            // Add all PictureBox controls on the form to the pictureBoxSlots list
            for (int i = 1; i<=12; i++)
            {
                PictureBox pic = Controls.Find("invSlot" + i, true).FirstOrDefault() as PictureBox;
                if (pic != null)
                {
                    pictureBoxSlots.Add(pic);
                }
            }
        }

        private void FrmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    Hide();
                    break;
                case Keys.Escape:
                    Hide();
                    break;
                default:
                    break;
            }
        }
    }
}

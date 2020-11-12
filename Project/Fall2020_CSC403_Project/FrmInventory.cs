using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        private Inventory inventory;
        private Button[] inventorySlots;
        private Player player;
        private bool _active = true;
        public bool IsActive { get => _active; }


        public FrmInventory(Inventory inventory, Player player)
        {
            this.inventory = inventory;
            this.player = player;

            InitializeComponent();
            inventorySlots = new Button[inventory.GetMaxInventorySize()];
            this.FormClosing += new FormClosingEventHandler(FrmIventory_FormClosing);
            InitInvSlots();
        }

        // Forces the thread updating the inventory to abort when the
        // inventory window is closed.
        private void FrmIventory_FormClosing(object sender, EventArgs e)
        {
            _active = false; // Shows if the inventory UI is active
        }

        // Initializes the inventory UI.
        private void InitInvSlots()
        {
            inventorySlots = new Button[inventory.GetMaxInventorySize()];
            for (int i = 1; i <= inventory.GetMaxInventorySize(); i++)
            {
                inventorySlots[i - 1] = Controls.Find("InvSlot" + i.ToString(), true)[0] as Button;
                inventorySlots[i - 1].Tag = i-1;
            }
            UpdateInventory();
        }
        
        // Handles clicks on the inventory's buttons.
        private void InvSlot_Click(object sender, EventArgs e)
        {
            Button invSlot = sender as Button;
            int index = (int)invSlot.Tag;
            inventory.UseInventoryObject(index, player);
            UpdateInventory();
        }

        // Updates the inventory ui to match what is stored in the inventory.
        // This method is meant to be called from a secondary thread.
        public void UpdateInventory()
        {
            for (int i = 0; i < inventory.GetMaxInventorySize(); i++)
            {
                if (inventory.GetInventoryObject(i) != null)
                {
                    InventoryObject iObj = inventory.GetInventoryObject(i);
                    inventorySlots[i].BackgroundImage = iObj.img;
                    if (iObj.IsStackable)
                    {
                        inventorySlots[i].Text = inventory.GetInventoryObject(i).GetCount().ToString();
                    }
                    else
                    {
                        inventorySlots[i].Text = "";
                    }
                }
                else
                {
                    inventorySlots[i].BackgroundImage = null;
                    inventorySlots[i].Text = "";
                }
            }
        }
    }
}

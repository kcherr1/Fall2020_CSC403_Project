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

        public FrmInventory(Inventory inventory, Player player)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.player = player;
            inventorySlots = new Button[inventory.GetMaxInventorySize()];
            InitInvSlots();
            //UpdateInventory();
            Thread invUpdater = new Thread(ContinuousUpdate);
            invUpdater.Start();
        }

        private void ContinuousUpdate()
        {
            while (true)
            {
                UpdateInventory();
                Thread.Sleep(250);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
        

        private void InvSlot_Click(object sender, EventArgs e)
        {
            Button invSlot = sender as Button;
            int index = (int)invSlot.Tag;
            inventory.UseInventoryObject(index, player);
            UpdateInventory();
        }

        private void UpdateInventory()
        {
            for (int i = 0; i < inventory.GetMaxInventorySize(); i++)
            {
                if (inventory.GetInventoryObject(i) != null)
                {
                    InventoryObject iObj = inventory.GetInventoryObject(i);
                    inventorySlots[i].Image = iObj.img;
                    if (iObj.IsStackable())
                    {
                        //inventorySlots[i].Text = inventory.GetInventoryObject(i).GetCount().ToString();
                        this.Invoke(new MethodInvoker(delegate()
                        {
                            inventorySlots[i].Text = inventory.GetInventoryObject(i).GetCount().ToString();
                        }));
                    }
                    else
                    {
                        inventorySlots[i].Text = "";
                    }
                }
                else
                {
                    inventorySlots[i].Image = null;
                    inventorySlots[i].Text = "";
                }

            }
        }
    }
}

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
        private FrmInventory instance;
        private Button[] inventorySlots;
        private Player player;
        private Thread invUpdater;
        private bool active;


        public FrmInventory(Inventory inventory, Player player)
        {
            this.inventory = inventory;
            this.player = player;
        }

        // Creates an instance of this class with a visible 
        // interface for the inventory
        private void Instance()
        {
            InitializeComponent();
            inventorySlots = new Button[inventory.GetMaxInventorySize()];
            InitInvSlots();
            this.FormClosing += new FormClosingEventHandler(FrmIventory_FormClosing);
            invUpdater = new Thread(ContinuousUpdater);
            invUpdater.Start();
            active = true;
        }

        // Manages another instance of this class with a visible 
        // interface for the inventory
        public void ShowInventory()
        {
            if(instance == null)
            {
                instance = new FrmInventory(inventory,player);
                instance.Instance();
                
            }
            else if (!instance.IsActive())
            {
                instance = new FrmInventory(inventory, player);
                instance.Instance();
            }
            instance.Show();
        }

        // Returns if the inventory updater thread is active.
        public bool IsActive()
        {
            return active;
        }

        // Forces the thread updating the inventory to abort when the
        // inventory window is closed.
        private void FrmIventory_FormClosing(object sender, EventArgs e)
        {
            active = false;
            invUpdater.Abort();
            
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
        }
        
        // Handles clicks on the inventory's buttons.
        private void InvSlot_Click(object sender, EventArgs e)
        {
            Button invSlot = sender as Button;
            int index = (int)invSlot.Tag;
            inventory.UseInventoryObject(index, player);
        }

        // The UI is updated every 250ms, meant to be used in a separate thread
        // from the main game.
        private void ContinuousUpdater()
        {
            while (active)
            {
                UpdateInventory();
                Thread.Sleep(50);
            }
            
        }

        // Updates the inventory ui to match what is stored in the inventory.
        // This method is meant to be called from a secondary thread.
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

                        // Allows the inventory updater thread to update the UI elements
                        // in the inventory from outside of the main thread.
                        try
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                inventorySlots[i].Text = inventory.GetInventoryObject(i).GetCount().ToString();
                            }));
                        }
                        catch(Exception e)
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                inventorySlots[i].Text = "";
                            }));
                        }
                        catch (Exception e)
                        {
                        }
                        
                    }
                }
                else
                {
                    try
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            inventorySlots[i].Image = null;
                            inventorySlots[i].Text = "";
                        }));
                    }
                    catch (Exception e)
                    {
                    }
                    
                }
            }
        }
    }
}

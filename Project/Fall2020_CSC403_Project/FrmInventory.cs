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
    public FrmInventory()
    {
      Console.WriteLine("he2");
      InitializeComponent();
    }

    public void FrmInventory_Load()
    {
      var inventory = Game.player.items;
      foreach (var item in inventory)
      {
        Console.WriteLine("hey");
        var row = new string[] { item.Name, item.Type, item.Value.ToString() };
        var lvi = new ListViewItem(row);
        // lvi.Tag = item;
        listViewInventory.Items.Add(lvi);
      }
    }

    private void Label1_Click(object sender, EventArgs e)
    {

    }

    private void CloseForm()
    {
      listViewInventory.Items.Clear();
    }
  }
}

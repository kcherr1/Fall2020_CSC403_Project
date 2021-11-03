using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class HostForm : Form
    { 


        public HostForm()
        {
            IsMdiContainer = true;
            AutoScroll = false;
            VScroll = false;
            HScroll = false;
            AutoSizeMode = AutoSizeMode.GrowOnly;
            AutoSize = true;
        }

        protected ChildForm CreateChild(ChildForm newChild)
        {
            newChild.MdiParent = this;
            newChild.Parent = this;
            newChild.ShowRequest += OnShowRequest;
            newChild.HideRequest += OnHideRequest;
            newChild.ChildCreateChild += OnChildCreateChild;

            return newChild;
        }

        protected void OnShowRequest(object sender, ShowRequestArgs e)
        {
            e.child.Show();
        }

        protected void OnHideRequest(object sender, HideRequestArgs e)
        {
            e.child.Hide();
        }

        protected void OnChildCreateChild(object sender, ChildCreateChildArgs e)
        {
            e.created.MdiParent = this;
            e.created.Creator = e.creator;

        }
    }


    public class ShowRequestArgs : EventArgs
    {
        public ChildForm child { get; set; }
    }

    public class HideRequestArgs : EventArgs
    {
        public ChildForm child { get; set; }
    }

    public class ChildCreateChildArgs : EventArgs
    {
        public ChildForm creator { get; set; }
        public ChildForm created { get; set; }
    }

}

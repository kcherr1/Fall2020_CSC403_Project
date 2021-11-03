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
    public class ChildForm : Form
    {

        public event EventHandler<ShowRequestArgs> ShowRequest;
        public event EventHandler<HideRequestArgs> HideRequest;
        public event EventHandler<ChildCreateChildArgs> ChildCreateChild;
        public ChildForm Creator;
        public HostForm Parent;
        public ChildForm()
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        protected ChildForm CreateChild(ChildForm newChild)
        {
            ChildCreateChildArgs args = new ChildCreateChildArgs();
            args.creator = this;
            args.created = newChild;

            EventHandler<ChildCreateChildArgs> handler = ChildCreateChild;
            handler(this, args);
            return newChild;
        }

        public void RequestHide()
        {
            HideRequestArgs args = new HideRequestArgs();
            args.child = this;
            EventHandler<HideRequestArgs> handler = HideRequest;
            handler(this, args);
        }

        public void RequestShow()
        {
            ShowRequestArgs args = new ShowRequestArgs();
            args.child = this;
            EventHandler<ShowRequestArgs> handler = ShowRequest;
            handler(this, args);

        }

        protected void CloseCleanly()
        {
            Creator.RequestShow();
            Close();
        }
    }
}

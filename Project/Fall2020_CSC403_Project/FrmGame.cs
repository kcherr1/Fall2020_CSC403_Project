using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project
{
    public partial class FrmGame : HostForm
    {
        public FrmLevel level;
        private FrmMainMenu mainmenu;

        
        public FrmGame()
        {    
            Load += new EventHandler(this.FrmGame_Load);
            KeyDown += new KeyEventHandler(this.FrmGame_Keydown);
            InitializeComponent();
        }

        public void FrmGame_Load(object sender, EventArgs e)
        {
            //level = (FrmLevel) CreateChild(new FrmLevel());
            //level.Show();
            //level.Focus();
            mainmenu = (FrmMainMenu)CreateChild(new FrmMainMenu());
            mainmenu.Show();
            mainmenu.Focus();

            this.Size = new Size(1200, 800);
            this.CenterToScreen();
        }

        private void FrmGame_Keydown(object sender, KeyEventArgs e)
        {
            
            Console.WriteLine(e.KeyValue);
            level.keyListener(e);
        }

        public void requestHide(Form child)
        {
            child.Hide();
        }

        public void RequestShow(Form child)
        {
            child.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._2.FlagsOfTheWorld.MenuItem
{
    public partial class MainMenu : UserControl
    {
        public event EventHandler StartGame;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.StartGame != null)
                this.StartGame(this, e);
        }
    }
}

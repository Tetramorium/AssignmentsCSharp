using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._7.YahtzeeGame.View.Partial
{
    public partial class MainMenu : UserControl
    {
        public event EventHandler GameStarted;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void bt_StartGame_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.GameStarted != null)
                this.GameStarted(this, e);
        }
    }
}

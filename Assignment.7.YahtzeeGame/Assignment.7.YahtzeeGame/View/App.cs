using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._7.YahtzeeGame.View
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            this.mainMenu1.GameStarted += MainMenu1_GameStarted;
        }

        private void MainMenu1_GameStarted(object sender, EventArgs e)
        {
            this.mainMenu1.Hide();

            this.gameMenu1.StartGame();

            this.gameMenu1.Show();
        }
    }
}

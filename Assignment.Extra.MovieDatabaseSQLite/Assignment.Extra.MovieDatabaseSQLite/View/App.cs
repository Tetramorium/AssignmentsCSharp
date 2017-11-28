using Assignment.Extra.MovieDatabaseSQLite.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Extra.MovieDatabaseSQLite.View
{
    public partial class App : Form
    {

        private DatabaseController dc;

        public App()
        {
            InitializeComponent();
            dc = new DatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dc.DisplayMovies();
        }
    }
}

using Assignment.Extra.MovieDatabaseSQLite.Controller;
using Assignment.Extra.MovieDatabaseSQLite.Model;
using Assignment.Extra.MovieDatabaseSQLite.View.Partial;
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

            foreach (Movie m in dc.GetMovies())
            {
                this.flp_MovieFlow.Controls.Add(new MovieViewPartial(m.Name, m.ReleaseDate));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dc.DisplayMovies();
        }
    }
}

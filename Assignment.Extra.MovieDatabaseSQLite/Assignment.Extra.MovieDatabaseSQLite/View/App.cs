using Assignment.Extra.MovieDatabaseSQLite.Controller;
using Assignment.Extra.MovieDatabaseSQLite.Model;
using Assignment.Extra.MovieDatabaseSQLite.View.MessageBox;
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
        public App()
        {
            InitializeComponent();

            DatabaseController.InitialSetup();

            foreach (Movie m in DatabaseController.GetMovies())
            {
                this.flp_MovieFlow.Controls.Add(new MovieViewPartial(m.Name, m.ReleaseDate));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseController.DisplayMovies();
        }

        private void bt_AddMovie_Click(object sender, EventArgs e)
        {
            AddMovieView amv = new AddMovieView();
            DialogResult dialogResult = amv.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                DatabaseController.AddMovie(amv.newMovie);
                this.flp_MovieFlow.Controls.Add(new MovieViewPartial(amv.newMovie));

            }
        }
    }
}

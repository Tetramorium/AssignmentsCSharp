using Assignment.Extra.MovieDatabaseSQLite.Controller;
using Assignment.Extra.MovieDatabaseSQLite.Model;
using Assignment.Extra.MovieDatabaseSQLite.View.CustomMessageBox;
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

            addDeleteEvents();
        }

        private void addDeleteEvents()
        {
            foreach(Control c in this.flp_MovieFlow.Controls)
            {
                MovieViewPartial mvp = (MovieViewPartial)c;

                mvp.DeleteMovieClick += Mvp_DeleteMovieClick;
            }
        }

        private void Mvp_DeleteMovieClick(object sender, EventArgs e)
        {
            MovieViewPartial mvp = (MovieViewPartial)sender;

            DialogResult d = MessageBox.Show("Are you sure you want to delete this movie?", String.Format("{0}", mvp.MovieName), MessageBoxButtons.OKCancel);

            if (d == DialogResult.OK)
            {
                DatabaseController.DeleteMovie(mvp.MovieName);
                this.flp_MovieFlow.Controls.Remove(mvp);
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
                MovieViewPartial mvp = new MovieViewPartial(amv.newMovie);
                mvp.DeleteMovieClick += Mvp_DeleteMovieClick;
                this.flp_MovieFlow.Controls.Add(mvp);
            }
        }
    }
}

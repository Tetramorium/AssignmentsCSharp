using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Extra.MovieDatabaseSQLite.Model;
using Assignment.Extra.MovieDatabaseSQLite.Controller;

namespace Assignment.Extra.MovieDatabaseSQLite.View.Partial
{
    public partial class MovieViewPartial : UserControl
    {

        public event EventHandler DeleteMovieClick;

        public string MovieName
        {
            get { return this.lbl_MovieName.Text; }
            set { this.lbl_MovieName.Text = value; }
        }


        public MovieViewPartial(string name, DateTime releaseDate)
        {
            InitializeComponent();

            this.lbl_MovieName.Text = name;
            this.lbl_MovieReleaseDate.Text = releaseDate.ToString(("yyyy-MM-dd"));
        }

        public MovieViewPartial(Movie _Movie)
        {
            InitializeComponent();

            this.lbl_MovieName.Text = _Movie.Name;
            this.lbl_MovieReleaseDate.Text = _Movie.ReleaseDate.ToString(("yyyy-MM-dd"));
        }

        private void bt_DeleteMovie_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            this.DeleteMovieClick?.Invoke(this, e);
        }
    }
}

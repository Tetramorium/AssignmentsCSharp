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
        public event EventHandler EditMovieClick;

        public string MovieName
        {
            get { return this.rtb_MovieName.Text; }
            set { this.rtb_MovieName.Text = value; }
        }

        public DateTime MovieReleaseDate
        {
            get { return Convert.ToDateTime(this.lbl_MovieReleaseDate.Text); }
            set { this.lbl_MovieReleaseDate.Text = value.ToString("yyyy-MM-dd"); }
        }

        public int MovieId { get; set; }


        public MovieViewPartial(int _Id, string _Name, DateTime _ReleaseDate)
        {
            InitializeComponent();

            this.MovieId = _Id;
            this.rtb_MovieName.Text = _Name;
            this.lbl_MovieReleaseDate.Text = _ReleaseDate.ToString(("yyyy-MM-dd"));
        }

        public MovieViewPartial(Movie _Movie)
        {
            InitializeComponent();

            this.MovieId = _Movie.Id;
            this.rtb_MovieName.Text = _Movie.Name;
            this.lbl_MovieReleaseDate.Text = _Movie.ReleaseDate.ToString(("yyyy-MM-dd"));
        }

        private void bt_DeleteMovie_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            this.DeleteMovieClick?.Invoke(this, e);
        }

        private void bt_EditMovie_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            this.EditMovieClick?.Invoke(this, e);
        }
    }
}

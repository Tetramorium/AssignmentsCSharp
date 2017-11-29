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

namespace Assignment.Extra.MovieDatabaseSQLite.View.Partial
{
    public partial class MovieViewPartial : UserControl
    {
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
    }
}

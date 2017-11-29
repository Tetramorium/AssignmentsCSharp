using Assignment.Extra.MovieDatabaseSQLite.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Extra.MovieDatabaseSQLite.View.MessageBox
{
    public partial class AddMovieView : Form
    {
        public Movie newMovie { get; set; }

        public AddMovieView()
        {
            InitializeComponent();
        }

        private void bt_Accept_Click(object sender, EventArgs e)
        {
            if (tb_MovieName.Text.Trim() == "")
            {
                this.DialogResult = DialogResult.None;
            } else
            {
                this.newMovie = new Movie(this.tb_MovieName.Text, this.dtp_MovieReleaseDate.Value);
            }
        }
    }
}

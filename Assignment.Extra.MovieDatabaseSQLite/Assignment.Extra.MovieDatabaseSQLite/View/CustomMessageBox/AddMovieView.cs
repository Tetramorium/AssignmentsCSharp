using Assignment.Extra.MovieDatabaseSQLite.Controller;
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

namespace Assignment.Extra.MovieDatabaseSQLite.View.CustomMessageBox
{
    public partial class AddMovieView : Form
    {
        public Movie NewMovie { get; set; }
        public string OldMovieName { get; set; }

        public AddMovieView()
        {
            InitializeComponent();
        }

        public AddMovieView(string _NewMovieName, DateTime _NewMovieReleaseDate)
        {
            InitializeComponent();

            this.OldMovieName = _NewMovieName;
            this.tb_MovieName.Text = _NewMovieName;
            this.dtp_MovieReleaseDate.Value = _NewMovieReleaseDate;
        }

        private void bt_Accept_Click(object sender, EventArgs e)
        {
            if (tb_MovieName.Text.Trim() == "")
            {
                this.DialogResult = DialogResult.None;
            } else
            {
                if (OldMovieName == this.tb_MovieName.Text || !DatabaseController.CheckIfMovieExists(this.tb_MovieName.Text))
                {
                    this.NewMovie = new Movie(this.tb_MovieName.Text, this.dtp_MovieReleaseDate.Value);
                } else
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("Movie already exists in database");
                }
            }
        }
    }
}

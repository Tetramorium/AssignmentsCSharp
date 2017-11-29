using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Extra.MovieDatabaseSQLite.Model
{
    public class Movie
    {
        [Key]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Movie()
        {

        }

        public Movie(string _Name, DateTime _ReleaseDate)
        {
            this.Name = _Name;
            this.ReleaseDate = _ReleaseDate;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Release: {1}", Name, ReleaseDate.ToString(("yyyy-MM-dd")));
        }
    }
}

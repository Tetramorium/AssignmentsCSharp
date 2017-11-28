using Assignment.Extra.MovieDatabaseSQLite.Model;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Extra.MovieDatabaseSQLite.Controller
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("Data Source=Database.sqlite;Version=3;")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}

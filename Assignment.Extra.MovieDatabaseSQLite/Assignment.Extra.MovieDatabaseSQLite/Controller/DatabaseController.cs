using Assignment.Extra.MovieDatabaseSQLite.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Extra.MovieDatabaseSQLite.Controller
{
    public class DatabaseController
    {
        public DatabaseController()
        {
            if (!System.IO.File.Exists("Database"))
            {
                InitialSetup();
            }

            using (DatabaseContext dc = new DatabaseContext())
            {
                dc.Movies.Add(new Movie { Name = "Die Hard", ReleaseDate = new DateTime(1992, 01, 24) });
                dc.SaveChanges();
            }
        }


        private void InitialSetup()
        {
            SQLiteConnection.CreateFile("Database.sqlite");

            using (SQLiteConnection c = new SQLiteConnection("Data Source=Database.sqlite;Version=3;"))
            {
                c.Open();
                string sql = "CREATE TABLE movies (name VARCHAR(32), date ReleaseDate)";
                SQLiteCommand command = new SQLiteCommand(sql, c);
                command.ExecuteNonQuery();
                c.Close();
            }
        }
    }
}

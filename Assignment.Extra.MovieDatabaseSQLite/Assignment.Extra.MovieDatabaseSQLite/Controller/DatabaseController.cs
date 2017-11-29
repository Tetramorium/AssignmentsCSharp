using Assignment.Extra.MovieDatabaseSQLite.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Extra.MovieDatabaseSQLite.Controller
{
    public static class DatabaseController
    {
        public static void InitialSetup()
        {
            if (!System.IO.File.Exists("Database.sqlite"))
            {
                SQLiteConnection.CreateFile("Database.sqlite");

                using (DatabaseContext dc = new DatabaseContext())
                {
                    dc.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS 'Movies' ('Name' TEXT NOT NULL PRIMARY KEY, 'ReleaseDate' date)");
                    dc.Movies.Add(new Movie { Name = "Die Hard", ReleaseDate = new DateTime(1988, 11, 3) });
                    dc.SaveChanges();
                }
            }
        }

        public static void AddMovie(Movie _Movie)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                dc.Movies.Add(_Movie);
                dc.SaveChanges();
            }
        }

        public static List<Movie> GetMovies()
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                return dc.Movies.ToList();
            }
        }

        public static void DisplayMovies()
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                foreach (Movie m in dc.Movies)
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
    }
}

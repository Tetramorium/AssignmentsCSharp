﻿using Assignment.Extra.MovieDatabaseSQLite.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    dc.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS 'Movies' ('Id' INTEGER PRIMARY KEY AUTOINCREMENT,'Name' TEXT NOT NULL, 'ReleaseDate' date, CONSTRAINT name_unique UNIQUE (Name))");
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

        public static void DeleteMovie(int _MovieId)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                Movie m = dc.Movies.Find(_MovieId);

                if (m != null)
                {
                    dc.Movies.Remove(m);
                    dc.SaveChanges();
                }
            }
        }

        public static void EditMovie(int _MovieId, Movie _NewMovie)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                Movie m = dc.Movies.Find(_MovieId);

                if (m != null)
                {
                    m.Name = _NewMovie.Name;
                    m.ReleaseDate = _NewMovie.ReleaseDate;

                    dc.Entry(m).State = EntityState.Modified;           
                    dc.SaveChanges();
                }
            }
        }

        public static Boolean CheckIfMovieExists(string _MovieName)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                Movie m = dc.Movies.FirstOrDefault(e => e.Name == _MovieName);

                if (m != null)
                {
                    return true;
                }

                return false;
            }
        }

        public static List<Movie> GetMovies()
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                return dc.Movies.ToList();
            }
        }

        public static List<Movie> SearchMovie(string _MovieNamePartial)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                return dc.Movies.Where(e => e.Name.ToLower().Contains(_MovieNamePartial.ToLower())).ToList();
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

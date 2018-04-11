using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsoleApp
{
    class Movie
    {
        public string MovieName { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public List<string> ActorNames { get; private set; }

        public Movie(string movieName, DateTime releaseDate, double rating)
        {
            MovieName = movieName;
            ReleaseDate = releaseDate;
            Rating = rating;
            ActorNames = new List<string>();
        }

        public Movie()
        {
            ActorNames = new List<string>();
        }
    }
}

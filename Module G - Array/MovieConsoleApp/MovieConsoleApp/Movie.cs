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

        public string[] ActorNames { get; private set; }

        public Movie()
        {
            ActorNames = new string[3];

            //Shortcut to declare elements if known beforehand
            //ActorNames = new string[] { "Chris Evans", "Robert Downey Jr.", "Scarlett Johansson" };
        }

        public Movie(string movieName, DateTime releaseDate, double rating)
        {
            MovieName = movieName;
            ReleaseDate = releaseDate;
            Rating = rating;
        }
    }
}

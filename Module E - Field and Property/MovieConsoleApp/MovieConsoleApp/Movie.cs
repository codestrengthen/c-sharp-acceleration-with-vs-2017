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

        public int MyProperty { get; set; }

        private DateTime releaseDate;
        public DateTime ReleaseDate
        {
            get { return releaseDate; }

            set { releaseDate = value; }
        }

        private double movieRating;
        public double MovieRating
        {
            get { return movieRating; }

            set { movieRating = value; }
        }

        public void TestMethod()
        {
            this.MovieName = "Frozen";
        }
    }
}

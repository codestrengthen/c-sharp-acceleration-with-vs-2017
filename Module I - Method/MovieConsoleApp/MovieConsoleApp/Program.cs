using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie
            {
                MovieName = "Captain America - Civil War",
                ReleaseDate = new DateTime(2016, 4, 28),
                Rating = 7.9,
            };
            movie1.AddActor("Chris Evans");
            movie1.AddActor("Robert Downey Jr.");
            movie1.AddActor("Scarlett Johansson");

            // movie1.ActorNames.ForEach(name => Console.WriteLine(name));
            // Console.WriteLine(movie1.CountActors());

            Movie movie2 = new Movie("The Avengers", new DateTime(2012, 4, 25), 8.1);
            List<string> actorNameList = new List<string>() { "Mark Ruffalo", "Chris Hemsworth", "Jeremy Renner" };
            movie2.AddActor(actorNameList);
            movie2.ActorNames.ForEach(name => Console.WriteLine(name));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___MovieRecommender
{
    //I
    //Public - access for MovieRecommender.cs
    public class Movie
    {
        //II
        public string MovieName { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double IMDbRating { get; set; }

        public string Genre { get; set; }

        public List<string> ActorNames { get; private set; }

        public Movie()
        {
            ActorNames = new List<string>();
        }

        public Movie(string movieName, DateTime releaseDate, double rating)
        {
            MovieName = movieName;
            ReleaseDate = releaseDate;
            IMDbRating = rating;
            ActorNames = new List<string>();
        }

        public void AddActor(string actorName)
        {
            //Check if the parameter is valid (ex. is it NULL or empty?)
            //Log the result into some log files for issue tracking later
            ActorNames.Add(actorName);
        }

        public void AddActor(List<string> actorNames)
        {
            ActorNames.AddRange(actorNames);
        }

        public int CountActors()
        {
            return ActorNames.Count;
        }
    }
}

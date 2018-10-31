using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___MovieRecommender
{
    class Program
    {
        static void Main(string[] args)
        {
            //VII
            Console.WriteLine("Welcome to Movie Recommender 2017!");

            //VIII
            /*To implement the req of showing a friendly message when data from Excel file cannot be loaded,
             I will need a Variable to keep track of the importing task's result
             */
            //Static = Class Members can be access thru Class name
            //ImportExcelMovieFile() -> Ctrl + . -> Method signature in MovieRecommender.cs
            bool result = MovieRecommender.ImportExcelMovieFile();
            //Result - check if it's true
            if (result) //= if (result == true)
            {
                //print out total number of movies and accepts user's commands
                Console.WriteLine($"We have {MovieRecommender.MostPopularMovies2017.Count} movies in total:");

                //Write all Object's properties from list
                foreach (var i in MovieRecommender.MostPopularMovies2017)
                {
                    Console.WriteLine("1st Movie Name: {0}, Genre: {1}, IMDb Rating: {2}", i.MovieName, i.Genre, i.IMDbRating);
                }

                Console.WriteLine("\t");
                /*
                MostPopularMovies2017.ForEach(i => Console.WriteLine(i)); 
                =
                MostPopularMovies2017.ForEach(Console.WriteLine);
                */

                MovieRecommender.MostPopularMovies2017.ForEach(i => Console.WriteLine("2nd Movie Name: {0}, Genre: {1}, IMDb Rating: {2}", i.MovieName, i.Genre, i.IMDbRating));

                Console.WriteLine("Your commands: a - Action, c - Comedy, r - Romance, l - list recommended movies, e - Exit program");
                MovieRecommender.ProcessUserInput();
            }
            else
            {
                //Pro behaviour - user won't be left confused if program crashes
                Console.WriteLine("There is a problem importing movies data. Please contact support or try again later.");
            }
        }
    }
}

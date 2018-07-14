using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___MovieConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IV
            /*Object - 1 - creation
            Class, VariableName = Constructor
            Movie testMovie = new Movie();
            */

            //VII
            //1st movie Object - without Parameters
            /*Constructor - default: has empty (), cause doesn't require Parameters
            //Class VariableName = new Class
            Movie movie1 = new Movie();

            //VIII
            //Object's Properties - assign values
            movie1.MovieName = "Captain America - Civil War";
            movie1.ReleaseDate = new DateTime(2016, 4, 28);
            movie1.Rating = 7.9;
            */

            //XXXIV
            //Chaining Exceptions
            try
            {
                //IX
                /*Object Initializers - allow to create an Object without invoking the Constructor, 
                 followed by multiple lines of assignement Statements
                 - code is simpler than using movie1
                 - Object Initializers require the default Constructor - don't remove it
                 */
                //Constructor - default Constructor = it doesn't take any params
                //Class, VariableName = Constructor
                Movie movie1 = new Movie
                {
                    //Objects Properties - assign values
                    //movie1.MovieName = "Captain America - Civil War"; - optimized to: MovieName = "Captain America - Civil War",
                    MovieName = "Captain America - Civil War",
                    ReleaseDate = new DateTime(2016, 4, 28),
                    Rating = 7.9
                };

                //X
                /*
                Composite Format String - like construct string template
                - common in constructing strings
                {0} - indexed placeholder from Object's arguments 
                - when the Program runs will be replaced with values from Properties as arguments 
                */
                Console.WriteLine("{0} is released on {1:dd/MM/yy} with rating is {2}", movie1.MovieName, movie1.ReleaseDate, movie1.Rating);

                //XV
                //Array - 4
                //Assign values to Array
                movie1.ActorNames[0] = "Chris Evans";
                movie1.ActorNames[1] = "Robert Downey Jr.";
                movie1.ActorNames[2] = "Scarlett Johansson";

                //XVI
                //Array - 5
                //Array values - test display
                Console.WriteLine("Actor names: {0}, {1}, {2}", movie1.ActorNames[0], movie1.ActorNames[1], movie1.ActorNames[2]);

                //XXI
                //Collection - 4
                //Add DirectorNames to List<string>
                movie1.DirectorNames.Add("Steven Spielberg");
                movie1.DirectorNames.Add("Andrew Wajda");
                movie1.DirectorNames.Add("Robert Zemeckis");
                movie1.DirectorNames.Add("Zack Snyder");
                movie1.DirectorNames.Remove("Andrew Wajda");

                //XXII
                //Collection - 5
                //DirectorsNames - access Property - LinkQuery
                //=> - lambda operator - specifies what to do with every element
                movie1.DirectorNames.ForEach(name => Console.WriteLine(name));
                Console.WriteLine("Andrew Wajda - IndexOf: " + movie1.DirectorNames.IndexOf("Andrew Wajda"));
                //AsNumerable - convert list to enumerable collection
                Console.WriteLine("AsEnumerable: " + movie1.DirectorNames.AsEnumerable());
                //Count - get no of elements in the list
                Console.WriteLine("Count: " + movie1.DirectorNames.Count());
                //FirstOrDefault - get 1st element or default value if list contains no elements
                Console.WriteLine("FirstOrDefault: " + movie1.DirectorNames.FirstOrDefault());
                //GroupBy - group to another list based on a key
                Console.WriteLine("GroupBy: " + movie1.DirectorNames.GroupBy(director => director.Length));
                //Where - filter the list based on a condition
                Console.WriteLine("Where: " + movie1.DirectorNames.Where(director => director.StartsWith("Z")));
                //Count
                Console.WriteLine("CountDirectors: " + movie1.CountDirectors());

                //XXIV
                //Method - 2
                //Method to add Directors
                movie1.AddDirector("Oliver Stone");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Attempted to access an element outside the ActorNames list's range");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("movie1's ActorNames list is not instantiated");
            }
            finally
            {
                Console.WriteLine("Enter Finally block");
            }
           
            //XI
            //2nd movie Object - 2nd Constructor (with Parameters)
            Movie movie2 = new Movie("The Avengers", new DateTime(2012, 4, 25), 8.1);

            Console.WriteLine("{0} is released on {1:dd/MM/yy} with rating is {2}", movie2.MovieName, movie2.ReleaseDate, movie2.Rating);

            //XXVII
            //Method - 5
            //Assign names to directNameList
            List<string> directorNameList = new List<string>() { "Mark Ruffalo", "Chris Hensworth", "Jeremy Renner" };
            //XXVIII
            //Method - 6
            //Call Method - AddDirector is Overloaded
            movie2.AddDirector(directorNameList);
            movie2.DirectorNames.ForEach(name => Console.WriteLine("directorNameList: " + name));

            //XXXI
            //Var - 3
            //Var - used instead of Movie
            var movie3 = new Movie("Star Trek", "S-F");
            List<string> countries = new List<string>() { "USA", "Poland", "Japan" };
            movie3.AddCountry(countries);
            
            //XXXII
            //Var - 5 - test display
            Console.WriteLine("movie3: " + movie3.MovieGenre + movie3.MovieName);
            movie3.CountriesAppearance.ForEach(name => Console.WriteLine(name));
            //XXXIII
            //Var - 7
            Console.WriteLine(movie3.GetType());
        }

            //Collections - generic
            //Dictionary
            private Dictionary<string, string> AussieStates { get; set; }

            public void InstantiateCollections()
            {
                AussieStates = new Dictionary<string, string>()
                {
                    {"NSW", "New South Wales" },
                    {"NT", "Northern Territory" },
                    {"QLD", "Queensland" },
                    {"SA", "SouthAustralia" },
                    {"TAS", "Tasmania" },
                    {"VIC", "Victoria" }
                };
            }
    }
}

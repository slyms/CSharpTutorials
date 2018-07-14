using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___MovieConsoleApp
{
    //I Step
    class Movie
    {
        /*
        //II
        //Field & Property - 1
        //Field
        private string movieName;
        
        //Field & Property - 2
        //Property
        public string MovieName
        {
            //Accessor body
            get
            {
                //Field name
                return movieName;
            }

            set
            {
                //Assigning to passed value to the field
                //value - refers to the passed in data from the calling Code
                movieName = value;
            }
        }
        */

        //III
        //Field & Property - 3
        //Auto-implemented Property
        public string MovieName { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        //XII
        //Array - 1
        //Array declaration = Access modifier, type[], Array name
        //private set - Program.cs cannot re-instantiate/reset the Array = extra protection
        public string[] ActorNames { get; private set; } 

        //XVIII
        //Collection - 1
        //Collection declaration 
        public List<string> DirectorNames { get; private set; }

        //XXX
        //Var - 1
        public string MovieGenre { get; set; }
        public List<string> CountriesAppearance { get; set; }

        public int MyProperty { get; set; }

        //V
        //Object - 2
        //Constructor - accept three Parameters, assign them to three Properties on Movie Class
        //Movie - Class name - tells the Program it's a Class Constructor
        public Movie(string movieName, DateTime releaseDate, double rating)
        {
            //Body - assign Parameters to Properties
            //Properties = Parameters
            MovieName = movieName;
            ReleaseDate = releaseDate;
            Rating = rating;

            //XIII
            //Array - 3
            ActorNames = new string[3];

            //XIX
            //Collection - 2
            //Class instantiation
            DirectorNames = new List<string>();
        }

        //VI
        //Constructor overloading - default Constructor & above same Constructor with different params
        public Movie()
        {
            //XIV
            //Array - 2
            //Array Object set inside the Constructor 
            //-> it will be instatiated only when Movie Object will be created
            //size = [3]
            ActorNames = new string[3];

            //XVII
            //Array - 6 END
            //Array elements can be assigned during Array initialization, if values are known
            //-> multiple assignment statements can be then removed - pt. 4
            ActorNames = new string[] { "Chris Evans", "Robert Downey Jr.", "Scarlett Johansson" };

            //XX
            //Collection - 3
            //Class instantiation
            DirectorNames = new List<string>();
        }

        //XXIII
        //Method - 1
        public void AddDirector(string directorName)
        {
            //Pass in director names to the list of director names
            DirectorNames.Add(directorName);
        }

        //XXV
        //Method - 3
        public int CountDirectors()
        {
            //Count - Poperty of List<T>
            //Count() - Method - also returns Count Property behind the scene = no difference betwen them
            return DirectorNames.Count;
        }

        //XXVI
        //Method - 4
        //Method - takes array of DirectorNames and adds them to DirectorList
        public void AddDirector(List<string> directorNames)
        {
            //AddRange access IEnumerable<T> - interface supported by List<T>
            //Other Collection times that also support IEnumerable<T> interface can also be supplied to AddRange Method
            DirectorNames.AddRange(directorNames);
        }

        //XXIX
        //Var - 2
        public Movie(string movieName, string movieGenre)
        {
            MovieName = movieName;
            MovieGenre = movieGenre;
            CountriesAppearance = new List<string>();
        }

        //
        //Var - 4
        public void AddCountry(List<string> country)
        {
            CountriesAppearance.AddRange(country);
        }
    }
}

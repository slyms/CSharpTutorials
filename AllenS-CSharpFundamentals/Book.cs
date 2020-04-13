using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AllenS_CSharpFundamentals
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    //Inheritance - base Class
    public class NamedObject
    {
        //Constructor - cause Book requiers string param during initialization: public Book(string name)
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        bool AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get;  }
        event GradeAddedDelegate GradeAdded;
    }

    //Abstract
    //A template - some common data for every Book
    public abstract class Book : NamedObject, IBook
    {
        //base = access Constructor from base Class = NamedObject, forward "name" to base
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract bool AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override bool AddGrade(double grade)
        {
            string path = @"C:\\Users\\Sylwester\\Desktop\\{Name}.txt";
            using (var writer = File.AppendText(path))
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            return true;
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }

    public class InMemoryBook : Book
    {
        /* Delegate for Event
         * object - can pass anything thru param 
         * 1st param = who sends Event 
         * 2nd - EventArgs = can pass additional info about Event
         * handle Event = add Method to this particular Event that we want invoked when this Class raises that Event
         * raising Event = invoking Delegate
         */
        //public delegate void GradeAddedDelegate(object sender, EventArgs args);

        /* Now every Book Object will have a GradeAdded Event
         * Any code that's interested in knowing when a grade has been added to GradeBook can find out,
         * cause we'll invoke this Delegate inside AddGrade()
         */
        public override event GradeAddedDelegate GradeAdded;
        
        /*Constructor
        base - access Constructor in base Class
        */
        public InMemoryBook(string name) : base(name)
        {
            CATEGORY = "";
            grades = new List<double>();
            //this.name = name - changing "name" to "Name", "this" is not needed
            Name = name;
        }

        //override - cause Book inherits from Bookbase
        public override bool AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                //If GradeAdded == null = no Reference to Delegate = no one is listening
                if(GradeAdded != null)
                {
                    /*params = accordingly to GradeAddedDelegate()
                    this = I am the sender
                    */
                    GradeAdded(this, new EventArgs());
                }
                return true;
            }
            else
            {
                Console.WriteLine("Invalid value");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            /*Initialized in Statistics.cs
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            */

            var sumGrade = 0.0;
            //var highestGrade = double.MinValue;
            //var lowestGrade = double.MaxValue;
            /*Alternative Loops
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            var index = 0;
            //if - needed in case grades = 0
            if(grades.Count > 0)
            {
                do
                {
                    result.High = Math.Max(grades[index], result.High);
                    result.Low = Math.Min(grades[index], result.Low);
                    result.Average += grades[index];
                    index++;
                }
                while (index < grades.Count);
            }
            var index = 0;
            while(index < grades.Count)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index++;
            }
            */

            for(var index = 0; index<grades.Count; index++)
            {
                if (grades[index] == 666)
                {
                    break;
                }

                result.Add(grades[index]);

                /*Moved to Statistics.cs
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                */
            }

            Console.WriteLine($"Grade Sum: {sumGrade}");

            //result.Average /= grades.Count;

            /*Moved to Statistics.cs
            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            */
            return result;
        }
        //Private - access only inside Book.cs
        private List<double> grades;

        //Initialize / change / write to - only in Constructor
        public readonly string CATEGORY = "Science";
        public const string school = "C# Academy";

        //Inheritance- Name is in base Class
        //Auto Property - alternative to classic definition
        /*public string Name
        {
            get;         //Read = public
            set; //Write = only from within Book.cs, can't change name after object construction
        }
        */

            /*
            private string name;

            public string Name
            {
                get
                {
                    return name.ToUpper();
                }
                set
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentNullException("Book name value cannot be Null");
                    }
                }
            }
            */
        }
    }

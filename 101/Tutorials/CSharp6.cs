using System;
// 4. Importing a single Class - can omit Console in Console.WriteLine
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace CSharpGuide.Tutorials
{
    public class CSharp6
    {
        public void CSharp6Method()
        {
            var p = new Person("Bill", "Wagner");
            WriteLine($"The name, in all caps: {p.AllCaps()}");
            WriteLine($"The name: {p}");

            p = new Person("Judy", "Francis", "Smith");
            // Writes only First & Lastname - because it's using override ToString()
            WriteLine("The name: " + p);
            WriteLine("The name: " + p.MiddleName);

            var phrase = "the quick brown fox jumps over the lazy do";
            var wordLength = from word in phrase.Split(' ') select word.Length;

            // 5. String interpolation - calculation can be performed as port of interpolated string
            //var average = wordLength.Average();
            //WriteLine($"The average word length in phrase: {average}");
            WriteLine($"The average word length in phrase: {wordLength.Average():F2}");

            // 6. Quick and easy null checks
            string s = null;
            WriteLine($"Null check Length: {s?.Length}");

            char? c = s?[0];
            WriteLine($"Null check HasValue: {c.HasValue}");

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            WriteLine($"Null check HasMore: {hasMore.HasValue}");

            // Null coalescing operator - simplification
            bool hasMoreCoalesc = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            WriteLine($"Null check HasMoreThanPrev: {hasMoreCoalesc}");

            s = "not null";
            hasMoreCoalesc = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            WriteLine($"Null check HasMoreThanPrev: {hasMoreCoalesc}");

            // 7. Exception filters
            try
            {
                s = null;
                WriteLine($"Try catch: {s.Length}");
            }
            catch (Exception e) when (LogException(e))
            {
            }
            WriteLine("Exception must have been handled");

            // 8. Using nameof
            CSharp6 csharp6 = new CSharp6();
            csharp6.ShowNameOf();

            // 9. New object initialization syntax
            csharp6.Initialization();

            ReadKey();
        }

        private static bool LogException(Exception e)
        {
            WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            WriteLine($"\tMessage: {e.Message}");
            return true;
        }

        private void ShowNameOf()
        {
            WriteLine($"Nameof: {nameof(System.String)}");
            int j = 5;
            WriteLine($"Nameof: {nameof(j)}");
            List<string> names = new List<string>();
            WriteLine($"Nameof: {nameof(names)}");
        }

        // 9. New object initialization syntax
        private void Initialization()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not found",
                [302] = "Page moved, but left a forwarding address",
                [500] = "The web server can't come out to play today"
            };

            WriteLine(messages[302]);
        }
    }

    public class Person
    {
        // Explore C# 6
        // 1. Read-only auto-properties enable read-only types
        public string FirstName { get; } //private set; - without it Property is readonly
        public string LastName { get; }
        // 2. Initialize backing fields for auto-properties
        public string MiddleName { get; } = "";

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        // 3. Expression-bodied members
        // 5. Better string format - string interpolation
        //public override string ToString()
        //{
        //    return FirstName + " " + LastName;
        //}
        public override string ToString() => $"{FirstName} {LastName}";

        //public string AllCaps()
        //{
        //    //FirstName = FirstName.ToUpper();
        //    //LastName = LastName.ToUpper();
        //    return ToString().ToUpper();
        //}
        public string AllCaps() => ToString().ToUpper();
    }

    // 9. New object initialization syntax
    //Point3D - error
    //public class Path : IEnumerable<Point3D>
    //{
    //    private List<Point3D> points = new List<Point3D>();
    //    public IEnumerator<Point3D> GetEnumerator() => points.GetEnumerator();
    //    IEnumerator<Point3D> IEnumerable<Point3D>.GetEnumerator() => points.GetEnumerator();

    //    public void Add(Point3D pt) => points.Add(pt);
    //}

    //public static class Extensions
    //{
    //    public static void Add(this Path path, double x, double y, double z) => path.Add(new Point3D(x, y, z));
    //}

    public class Point3D
    {
        private double _x;
        private double _y;
        private double _z;

        public Point3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}

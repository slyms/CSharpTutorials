using System;
using System.Reflection;

namespace CSharpGuide
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(10, 20);
            Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");
            Console.WriteLine($"X: {p2.X}, Y: {p2.Y}");

            var p3 = new Point3D(100, 200, 300);
            Console.WriteLine($"X: {p3.X}, Y: {p3.Y}, Z: {p3.Z}");

            //Constructed type
            var pair = new Pair<int, string>(1, "two");
            int i = pair.First; //TFirst int
            string s = pair.Second; //TSecond string
            Console.WriteLine($"pair: {pair.First} / {i}, {pair.Second} / {s}");

            Point a = new Point(11, 12);
            Point b = new Point3D(13, 14, 15);

            //Interface
            EditBox editBox = new EditBox();
            IControl control = editBox;
            IDataBound dataBound = editBox;

            //Struct
            SimpleStruct simpleStruct = new SimpleStruct(66.6, 88.8);
            Console.WriteLine($"simpleStruct.X: {simpleStruct.X}"); 
            Console.WriteLine($"simpleStruct.Y: {simpleStruct.Y}"); 

            //Enum
            var turnip = SomeRootVegetable.Turnip;
            var spring = Seasons.Spring;
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn | Seasons.Winter;
            var theYear = Seasons.All;
            Console.WriteLine($"turnip: {turnip}");
            Console.WriteLine($"spring: {spring}");
            Console.WriteLine($"startingOnEquinox: {startingOnEquinox}");
            Console.WriteLine($"theYear: {theYear}");

            //Nullable types
            int? optionalInt = default;
            Console.WriteLine($"optionalInt: {optionalInt}");
            optionalInt = 5;
            Console.WriteLine($"optionalInt: {optionalInt}");
            string? optionalText = default;
            Console.WriteLine($"optionalInt: {optionalText}");
            optionalText = "Optional Text";
            Console.WriteLine($"optionalInt: {optionalText}");

            //Tuples
            (double Sum, int Count) tuple = (4.5, 3);
            Console.WriteLine($"Sum of {tuple.Count} elements is {tuple.Sum}.");
        }
    }

    public class Point
    {
        public int X { get;  }
        public int Y { get;  }
        public Point(int x, int y) => (X, Y) = (x, y);
    }

    //Inheritance - Base class
    public class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }

    //Generic class type - type parameters
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }
        public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
    }

    //Struct
    public struct SimpleStruct
    {
        public double X { get; }
        public double Y { get; }
        public SimpleStruct(double x, double y) => (X, Y) = (x, y);
    }

    //Interface
    interface IDataBound
    {
        void Bind(Binder b);
    }
    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    //Multiple inheritance
    interface IComboBox : ITextBox, IListBox { }

    //Multiple inheritance
    public class EditBox: IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }

    //Enum
    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }

    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }
}

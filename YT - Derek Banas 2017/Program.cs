/*
Part I
- Introduction
- Input, Output
- Looping
- Data Types
- Strings
- Functions
Part II
Arrarys
For
For Each
*/

//Namespace declarations - libraries, provide useful functions & objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ref for BigIntegers
//Project > Add Ref > System.Numerics > check
using System.Numerics;

//Namespace - defines globally unique objects, to keep code unique
namespace YT___Derek_Banas_2017
{
    //Class - defines variables & methods used by objects
    class Program
    {
        //Main method - entry point of any C# app
        //static - function belongs to the class
        //it can be executed without needing to create an object
        //void - function doesn't return value after it executes
        //string[] - function is able to receive multiple values stored in string array
        static void Main()
        {
            //FirstLesson();
            //SayHello();
            //DataTypes();
            Strings();

            //Console - Class within System Namespace
            Console.Write("Pass Your input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Your input, Sir: " + input);

            int x = 10;
            if (x == 10)
            {
                Console.WriteLine("X is 10");
            }
        }

        private static void FirstLesson(string[] args)
        {
            Console.Write("Hello World!");
            Console.WriteLine("Hello World!");

            //For - loop
            for (int i = 0; i < args.Length; i++)
            {
                //1 2 3 4 - args taken from Project>Properties>Debug>Command Line Args
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            //Alt - display args from Command Line Args
            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", myArgs));
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        private static void DataTypes()
        {
            bool canIVote = true;

            //int - 32-bit signed integer
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            //long - 64-bit
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            //decimal - 128-bit precise decimal, 28digits accuracy
            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);

            decimal decPiVal = 3.1415926535897932384626433M;
            decimal decBigNum = 3.0000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            //double - 64-bitfloat
            Console.WriteLine("Biggest Double : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", double.MinValue);

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            //double - 32-bitfloat
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Float : {0}", float.MinValue);

            //float - 8-bit float
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            //Other data types
            //byte : 8-bit unsigned int, 0-255
            //char : 16-bit unicode character
            //sbyte : 8-bit signed int, 128-127
            //short: 16-bit signed int, -32,768-32,767
            //uint: 32-bit unsigned int, 0-4,294,967,295
            //ulong: 64-bit unsigned int, 0-18,446,774,073,709,551,615
            //ushort: 16-bit unsigned int, 0-65,535;

            //Parse - convert to string from other data types
            bool boolNotFromString = true;
            bool boolFromString = bool.Parse("false");

            int intNotFromString = 100;
            int intFromString = int.Parse("100");

            double dblNotFromString = 1.234;
            double dblFromString = double.Parse("1.234");

            Console.WriteLine("Is it a String?: " + boolNotFromString);
            Console.WriteLine("is it a String?: " + boolFromString);
            Console.WriteLine("Is it a String?: " + (intNotFromString - 2));
            Console.WriteLine("is it a String?: " + (intFromString - 2));
            Console.WriteLine("Is it a String?: " + (dblNotFromString - 2));
            Console.WriteLine("is it a String?: " + (dblFromString - 2));

            //Additional data types: Date & Time
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            awesomeDate = new DateTime(1983, 05, 25);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(4);
            awesomeDate = awesomeDate.AddYears(4);

            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            awesomeDate = DateTime.Today;
            //ToString - convert values to String
            Console.WriteLine("Today is : " + awesomeDate.ToString());

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));

            Console.WriteLine("Lunch time is (after substract): {0}", lunchTime.ToString());

            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("Lunch time is (after addition): {0}", lunchTime.ToString());

            //BigIntegers
            //Requires Ref: System.Numerics
            BigInteger bigNum = BigInteger.Parse("123451234512345123451234512345");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);

            //Formatting
            //Currency: $
            Console.WriteLine("Currency : {0:c}", 23.455);
            //0s added
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            //Decimals added
            Console.WriteLine("3 Decimals : {0:f3}", 23);
            //Commas & dots added for big ints & decimals
            Console.WriteLine("Commas : {0:n4}", 2300);
        }

        private static void Strings()
        {
            string randomString = "This is a String";

            //Length - index
            Console.WriteLine("String Length: {0}", randomString.Length);
            //Contains
            Console.WriteLine("String Contains is : {0}", randomString.Contains("is"));
            //Index
            Console.WriteLine("Index of is : {0}", randomString.IndexOf("is"));
            //Remove - Index
            Console.WriteLine("Remove String : {0}", randomString.Remove(0, 8));
            //Insert - at Index
            Console.WriteLine("Insert String : {0}", randomString.Insert(16, " ... and the World is Awesome again"));
            //Replace - string
            Console.WriteLine("Replace String : {0}", randomString.Replace("String", "sentence"));
            //Compare: 0=match, -1=1st string preceeds 2nd by alphabet
            //IgnoreCase
            Console.WriteLine("Compare A to B : {0}", String.Compare("B", "A", StringComparison.OrdinalIgnoreCase));
            //Equal
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.Ordinal));
            Console.WriteLine("(IgnoreCase) A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            //Pad
            Console.WriteLine("Pad Left : {0}", randomString.PadLeft(20, '.'));
            Console.WriteLine("Pad Left : {0}", randomString.PadRight(20, '.'));
            //Trim - white space
            Console.WriteLine("Trim : {0}", randomString.Trim());
            //Uppercase
            Console.WriteLine("Uppercase : {0}", randomString.ToUpper());
            //Lowercase
            Console.WriteLine("Lowercase : {0}", randomString.ToLower());

            //String - new
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.WriteLine(newString);

            //Escape
            string escapeString = "Escape for quotes \'' and double-quotes \" ";
            Console.WriteLine(escapeString);
            //Tab
            string tabString = "Tab used here: \t in preceeding place";
            Console.WriteLine(tabString);
            //Alert
            string alertString = "Alert heared here: \a";
            Console.WriteLine(alertString);
            //Verbatim - ignore escape sequence
            Console.WriteLine(@"Exactly What I Typed \/ ' ");
        }
    }
}

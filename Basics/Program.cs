using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Needed for MessagoBox.Show
using System.Windows.Forms;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction();
            SubstractionReturn(2, 1);
            SubstractionVoid(2, 1);
            Returning();
            MessageNumber("Number x is: ", 1);

            int x = StaticMethod(2, 3);
            Console.WriteLine("x is : " + x);
            Console.ReadKey();

            Overload(1, 4);
            Overload("1", "4");

        }

        public static void Introduction()
            {
            int x = 2;
            Console.WriteLine(x);

            //Operations
            //Concatenation
            string wordsAdd = "Strażnicy " + "Galaktyki " + "2";

            Console.WriteLine(wordsAdd);

            Console.BackgroundColor = ConsoleColor.Yellow;

            //Modulo
            int m = 5 / 2;
            Console.WriteLine("Modulo: " + m);

            //Data type - Conversion - common operation
            //Parse string to int
            int y = int.Parse("1") + int.Parse("2");
            Console.WriteLine("y = " + y);

            //Parse int to string
            string words = y.ToString();
            Console.WriteLine("After Parse: " + words);

            string fourString = "4";
            int fourInt = int.Parse(fourString);
            Console.WriteLine("fourInt / 2 = " + fourInt / 2);

            fourString = fourString.ToString();

            //Data type - numbers
            double a = 3 / 2;
            Console.WriteLine("a = " + a);
            //Return: 1
            //Division on two ints - although return was converted to double

            double b = 3.0 / 2.0;
            Console.WriteLine("b = " + b);
            //Return: 1.5
            //Both numbers and results are double

            double c = 3 / 2.0;
            Console.WriteLine("c = " + c);
            //Return: 1.5
            //Compilator compiles int to double before operation - result is double
            //Avoid: additional task for compiler 
            //& programmer not sure how code works before compilation

            //Division a number by 0
            //int, long, decimal = error
            //int five = 5 / 0;

            //double, float - infinity (plus & minus infinity)
            double six = (6.0 / 0) * 0;
            Console.WriteLine("six = " + six);
            //infinity * 0 = 0
            //NO! - it returns NaN
            six = six * 0;
            Console.WriteLine("six = " + six);

            //Division 0 by 0
            double z = 0;
            z = z / z;
            //z = NaN - Not a Number - result not specified
            Console.WriteLine("z = " + z);

            //Any operation with NaN returns NaN
            double d = 5 / z;
            Console.WriteLine("d = " + d);

            //Incrementation, Decrementation
            int count = 0;
            count++;
            Console.WriteLine("count++ = " + count);
            count--;
            Console.WriteLine("count-- = " + count);

            //Prefiks = 1.Operation 2.Variable
            Console.WriteLine("--count = " + --count);
            Console.WriteLine("count = " + count);
            //Sufix / Postfix = 1.Variable 2.Operation
            Console.WriteLine("count++ = " + count++);
            Console.WriteLine("count = " + count);
        }

        static int SubstractionReturn(int x1, int x2)
        {
            return x1 - x2;
        }

        static void SubstractionVoid(int x1, int x2)
        {
            MessageBox.Show("SubstractionVoid(): " + (x1 - x2).ToString());
        }

        static string Returning()
        {
            return "LOL";
            //Return - if variable has been already returned, rest of the code won't be executed
            string s = "This won't be executed";
        }

        static void MessageNumber(string communicate, int number)
        {
            MessageBox.Show(communicate + " : " + number.ToString());
        }

        static int StaticMethod(int x1, int x2)
        {
            return x1 * x2;
        }

        //Overload - two versions of same Method
        static int Overload(int o1, int o2)
        {
            MessageBox.Show("Overload with ints: " + (o1 + o2).ToString());
            return o1 + o2;
        }

        static string Overload(string o1, string o2)
        {
            MessageBox.Show("Overload with strings: " + (o1 + o2).ToString());
            return o1 + o2;
        }
    }
}

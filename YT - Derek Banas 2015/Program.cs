using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial___Derek_Banas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            UserInputDataTypes();
            Maths();
            Casting();
            MathFunctions();
            Conditionals();
            */
            Loops();
        }

        public static void UserInputDataTypes()
        {
            Console.WriteLine("UserInputDataTypes():");
            //Comment - 1 line
            /* Comment - multiline 
            */
            Console.Write("Hello World!");
            //New line after text
            Console.WriteLine("Hello World!");

            //USER INPUT
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //DATA TYPES
            bool canVote = true;
            //16-bit Unicode character
            char grade = 'A';
            //Numeric values
            //Max: 2,147,483,647
            int maxInt = int.MaxValue;
            //9,223,372,036,854,775,807
            long maxLong = long.MaxValue;
            //79,228,162,514,264,337,593,543,950,335
            decimal maxDec = decimal.MaxValue;
            //32-bit number, Max: 3.402823E+38, Precision: 7 decimals
            float maxFloat = float.MaxValue;
            //32-bit number, Max: 1.797693134E+308, Precision: 15 decimals
            double maxDouble = double.MaxValue;

            //String can be combined with other data type
            Console.WriteLine("Max Int: " + maxInt);

            //Defined whenever the program is compiled - then it's value can't be changed
            var anotherName = "Tom";

            anotherName = "Rebecca";
            Console.WriteLine(anotherName + " - anotherName is a {0}", anotherName.GetTypeCode());

            //anotherName data type can't be changed - it is considered as string according to what it was assigned to in the 1st place
            //anotherName = 3;
        }

        public static void Maths()
        {
            Console.WriteLine("Math():");
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;
            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3, i = " + (i += 3)); // i = i + 3
            Console.WriteLine("i -= 2, i = " + (i -= 2));
            Console.WriteLine("i *= 2, i = " + (i *= 2));
            Console.WriteLine("i /= 2, i = " + (i /= 2));
            Console.WriteLine("i %= 2, i = " + (i %= 2));
        }

        //Casting - converting; automatic when no magnitutde is lost
        public static void Casting()
        {
            Console.WriteLine("Casting(): ");
            double pi = 3.14;
            Console.WriteLine(pi);

            //(data type to be converted to)
            int intPi = (int)pi;
            Console.WriteLine(intPi);
        }

        public static void MathFunctions()
        {
            //Acos, Asin, Atan, Atan2, Ceiling, Cos, Cosh, Exp, Floor, Log, Max, Min, Pow, Round, Sin, Sinh, Sqrt, Tan, Tanh
            Console.WriteLine("MathFunctions(): ");

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));

            //Random
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + rand.Next(1, 11));
        }

        public static void Conditionals()
        {
            /*Operators
            Relational: > < >= <= == !=
            Logical: AND &&, OR ||, EX-OR ^, NOT !
            */

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age >= 7) && (age <= 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You are out of employement age");
            }

            Console.WriteLine("!true = " + (!true));

            //Ternary operator
            //If the condition is true, assign true to value, if false - assign false
            bool canDrivebool = age >= 16 ? true : false;
            Console.WriteLine("canDrivebool: " + canDrivebool);

            int canDriveint = age >= 16 ? 1 : 0;
            Console.WriteLine("canDriveint: " + canDriveint);
        }

        public static void Switch()
        {
            int age = 3;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    //Break - at the end of each statement allow program to exit each case after it's done
                    break;
                case 1:
                    //Go outside of switch - not specific in C#, better not use it
                    //Cute - label
                    goto Cute;
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                //None of case executed
                default:
                    Console.WriteLine("Child");
                    break;

            }
        Cute:
            Console.WriteLine("Toddlers are Cute");
        }

        public static void Loops()
        {
            Console.WriteLine("From here I've went to Derek Banas 2017");
        }
    }
}

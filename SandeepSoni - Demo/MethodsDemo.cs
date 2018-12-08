using System;

namespace SandeepSoni___Demo
{
    class MethodsDemo
    {
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }


        public static int Adding()
        {
            int n1, n2, result;
            n1 = 10; n2 = 30;
            result = AddingImplementation(n1, n2);

            //Method Overloading - casting Data Type
            byte b1, b2;
            b1 = 9; b2 = 2;

            byte b3, b4, b5;
            b3 = 3; b4 = 2; b5 = 1;

            //Method Overloading ambiguity
            //2 Methods have same no of params with same Data Type, but in different order
            //result = AddingImplementation(b3, b4, b5);

            //Optional Parameter
            int opt1, opt2, opt3, opt4;
            opt1 = 10;
            opt2 = 20;
            opt3 = 30;
            opt4 = 40;

            //params
            int[] arrayAddition = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Adding result: " + result);
            Console.WriteLine("Method Overloading - param Data Type " + AddingImplementation("Micro", "soft"));
            Console.WriteLine("Method Overloading - param no: " + AddingImplementation(1000, 22, 3));
            Console.WriteLine("Method Overloading - casting Data Type (byte to int): " + AddingImplementation(b1, b2));
            Console.WriteLine("Method Overloading - casting Data Type (byte & int available - closest match): " + AddingImplementation(b3, b4, b5));
            Console.WriteLine("Method Overloading - casting Data Type (byte & int available - matched by casting byte to int): " + AddingImplementation((int)n1, b4, b5));
            Console.WriteLine("Optional Parameter: " + OptionalParam(opt1, opt2));
            Console.WriteLine("Optional Parameter: " + OptionalParam(opt1, opt2, opt3, opt4));
            Console.WriteLine("Named Arguments - 'optionalOne' was skipped in Call: " + OptionalParam(333, 111, optionalTwo: 222));
            Console.WriteLine("Named Arguments - order changed: " + NamedArg(fourth: 111, third: 333, second: 111, first: 222));
            Console.WriteLine("AddingToArray(arrayAddition): " + AddingToArray(arrayAdding: arrayAddition));
            Console.WriteLine("AddingToArray(arrayAddition): " + AddingToArray(1, 2, 3, 4, 5, 6));
            Console.WriteLine("AddingToArray(arrayAddition): " + AddingToArray(1, 2, 3, 4, 5, 6, 7, 8));
            Console.WriteLine("AddingToArray(arrayAddition): " + AddingToArray());
            Console.WriteLine("AddingToArray(arrayAddition) SPECIFIC: " + AddingToArray(1, 2));

            //Pass by
            int passBy, passByOut, passByRef;
            passBy = passByOut = passByRef = 10;
            PassBy(passBy, out passByOut, ref passByRef);
            Console.WriteLine("passBy: " + passBy + " " + passByOut + " " + passByRef);

            NoReturns();

            return result;
        }

        public static int AddingImplementation(int a, int b)
        {
            return a + b;
        }

        //Method Overloading - param Data Type - different Data Type
        public static string AddingImplementation(string s, string r)
        {
            return s + r;
        }

        //Method Overloading - param Data Type - casting
        public static int AddingImplementation(byte c, byte d, byte e)
        {
            return c + d + e;
        }

        //Method Overloading - param Data Type - casting2
        public static int AddingImplementation(int a, byte d, byte e)
        {
            return a + d + e;
        }

        //Method Overloading - param no
        public static int AddingImplementation(int c, int d, int e)
        {
            return c + d + e;
        }

        //Optional Param
        public static int OptionalParam(int first, int second)
        {
            return first + second;
        }

        public static int OptionalParam(int first, int second, int optionalOne = 1, int optionalTwo = 2)
        {
            return first + second + optionalOne + optionalTwo;
        }

        //Named Arguments
        public static int NamedArg(int first, int second, int third, int fourth)
        {
            return first + second + third + fourth;
        }

        //params - flexible adding values to Array
        public static int AddingToArray(int a = 0, params int[] arrayAdding)
        {
            //Sum of values in arrayAdding
            int tmp = 0;
            foreach (int n in arrayAdding)
            {
                tmp += n;
            }
            return tmp;
        }

        //More specific - will be called if AddingToArray() with 2 args will be executed 
        public static int AddingToArray(int a, int b)
        {
            int specific = a - b;
            return specific;
        }

        //out - only gives value
        //ref - in & out
        static void PassBy(int PassBy, out int PassByOut, ref int PassByRef)
        {
            PassBy++; //normal param - it's value is not assigned back to PassBy argument in Calling Method
            PassByOut = 15;
            PassByRef++;
        }

        //Not all code paths return value - if no Else
        static int NoReturn(int noReturn)
        {
            if (noReturn != 0)
                return noReturn;
            else
                return noReturn;
        }

        //Infinite loop - no return & no limitation condition - but Compiler allows it with no error
        static int NoReturns()
        {
            int n = 0;
            while (true)
            //while (n=10)
            {
                n++;
                Console.WriteLine(n);
            }
        }
    }
}

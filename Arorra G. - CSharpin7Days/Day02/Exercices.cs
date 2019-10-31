using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;

namespace Day02Ex
{
    public class Exercices
    {
        public void ExercisesMethod(int x, int y)
        {
            int _x=x, _y=y, res;
            res = _x - _y;
            WriteLine("Day02 - res: " + res);
        }
    }
}

namespace Day02Ex_Second
{
    public class Exercices
    {
        public void ExercisesMethod(int x, int y)
        {
            int _x=x, _y=y, res;
            res = _x + _y;
            WriteLine("Day02Second - res: " + res);
        }
    }
}

namespace Main
{
    public class Program
    {
        public static void Main()
        {
            /*
            //1. Same class name within different namespaces
            int x, y;
            WriteLine("Enter two numbers: ");
            x = Convert.ToInt32(ReadLine());
            y = Convert.ToInt32(ReadLine());
            Day02Ex.Exercices exercices = new Day02Ex.Exercices();
            exercices.ExercisesMethod(x, y);
            Day02Ex_Second.Exercices exercicesSecond = new Day02Ex_Second.Exercices();
            exercicesSecond.ExercisesMethod(x, y);
            //2. Console colors - display vowels as green, and consonants as blue
            Console.ConsoleOperationExamples();
            //5. Create a small program to demonstrate the is and as operators
            GFG.IsOperator();
            GFG.AsOperator();
            */
            //6. Write a short program to showcase a query expression with the help of contextual keywords.
            Exercises op = new Exercises();
            op.ContextualKeywords();

            
            /*
            //7.Write a short program to showcase the importance of the this and base keywords.
            BankClients bankClients = new BankClients();
            bankClients.ShowNames();
            Bank bank = new Bank();
            bank.Pointer();

            //8. Define boxing and unboxing with the help of a short program.
            Exercises box = new Exercises();
            box.Box();
            //10. Write a short program to showcase the operator precedence order.
            
            op.OperatorPrecedence();
            //11.What is operator overloading? Write a short program to showcase operator overloading in action.
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 7);
            Fraction c = new Fraction(2, 3);
            WriteLine(a * b + c);

            SubMulti x = new SubMulti(4, 5);
            //x.value = 10;
            //y.value = 10;
            //SubMulti z = x + y;
            WriteLine(x.a + x.b);

            Widget w = new Widget();
            Widget g = new Widget();
            w.value = 7;
            g.value = 8;
            Widget t = w + g;
            WriteLine(t.value);

            //13. Define type conversion with the help of a short program.
            //14.Write a short program that uses all the available built-in C# types and perform casting using the conversion method (decimal to int conversion can be achieved using var result = Convert.ToInt32(5689.25);).
            op.Conversion();

            //16. Write a program to elaborate each statement category.
            op.Statements();
            //17. What are jump statements? Write a small program to showcase all jump statements.
            op.JumpStatements();
            //18. What is an array in C#?
            op.ArrayEx();
            //24. Refer to the System.String class and explore all its methods and properties with the help of a short program.
            op.StringMethods();
            //29. Write a small program and showcase the differences between a struct and a class.
            Store clastru = new Store();
            clastru.ClassAndStruct();
            //31. Write a program to show the difference between compile-time type and runtime type.
            Animal a = new Dog(); //new Dog() will execute just at runtime - till then, Compiler only knows that 'a' is Animal
            Dog d = (Dog)a; //(Dog) cast is needed

            a = new Cat();
            //d = (Dog)a; //Compiler accepts it - but at run-time: InvalidCastException
            //32. Write a short program to prove that, explicitly, type conversion leads to data loss.
            op.TypeConvert();
            */

            ReadLine();
        }
    }

    public class Console
    {
        public static void ConsoleOperationExamples()
        {
            WriteLine("2.Console colors - display vowels as green, and consonants as blue\n");
            var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            WriteLine("All available colors");
            (int vowel, int consonant) userInput;
            do
            {
                userInput = DisplayColorMenu(colors);
                if (userInput.consonant == colors.Length + 1 || userInput.vowel == colors.Length + 1)
                {
                    WriteLine("Resetting to default...");
                    ResetColor();
                    Write("Press any key to continue...");
                    ReadLine();
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.consonant < 0 || userInput.vowel < 0)
                {
                    WriteLine("-ve values are not allowed");
                }
                else if (userInput.vowel == colors.Length + 2 || userInput.consonant == colors.Length + 2)
                {
                }
                else
                {
                    ForegroundColor = colors[userInput.vowel];
                    WriteLine($"Vowel color is {ForegroundColor}");

                    ForegroundColor = colors[userInput.consonant];
                    WriteLine($"Consonant color is {ForegroundColor}");
                    ResetColor();
                    WriteLine();

                    Write("Type anything to see the changes: ");
                    string text = ReadLine();
                    char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
                    char[] consonants = new[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'w', 'x', 'z' };

                    WriteLine("Code with Array.Find");
                    for (int i = 0; i < text.Length; i++)
                    {
                        char index = Array.Find(vowels, element => element.Equals(text[i]));
                        if (index != 0)
                        {
                            ForegroundColor = colors[userInput.vowel];
                            Write(text[i]);
                        }

                        char s = Array.Find(consonants, element => element.Equals(text[i]));
                        if (s != 0)
                        {
                            ForegroundColor = colors[userInput.consonant];
                            Write(text[i]);
                        }
                    }
                    ResetColor();
                    WriteLine("\nCode with Contains");
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (vowels.Contains(text[i]))
                        {
                            ForegroundColor = colors[userInput.vowel];
                            Write(text[i]);
                        }
                        if (consonants.Contains(text[i]))
                        {
                            ForegroundColor = colors[userInput.consonant];
                            Write(text[i]);
                        }
                    }
                    ResetColor();
                    Write("\n");
                }
            }
            while (userInput.vowel != colors.Length + 2 || userInput.consonant != colors.Length + 2);
        }

        public static (int, int) DisplayColorMenu(ConsoleColor[] colors)
        {
            var count = 0;

            foreach (var color in colors)
            {
                WriteLine($"{count} {color}");
                count += 1;
            }
            WriteLine($"{count + 1} Reset");
            WriteLine($"{count + 2} Exit");

            Write("Choose Vowels color: ");
            var vowel = Convert.ToInt32(ReadLine());
            Write("Choose Consonants color: ");
            var consonant = Convert.ToInt32(ReadLine());

            return new ValueTuple<int, int>(vowel, consonant);
        }
    }

    public class P { }
    public class P1 : P { }
    public class P2 { }

    class Y { };
    class Z { };

    public class GFG
    {
        public static void IsOperator()
        {
            P instance = new P();
            P1 instance1 = new P1();
            WriteLine("instance is P: " + (instance is P));
            WriteLine("instance is P1: " + (instance is P1));
            WriteLine("instance is P2: " + (instance is P2));
            WriteLine("instance is Object: " + (instance is Object));
            WriteLine("instance1 is P: " + (instance1 is P));
            WriteLine("instance1 is P1: " + (instance1 is P1));
            WriteLine("instance1 is P2: " + (instance1 is P2));
            WriteLine("instance1 is Object: " + (instance1 is Object));
        }

        public static void AsOperator()
        {
            object[] o = new object[5];
            o[0] = new Y();
            o[1] = new Z();
            o[2] = "Hello";
            o[3] = 4759.0;
            o[4] = null;

            for(int q = 0; q < o.Length; ++q)
            {
                string str1 = o[q] as string;
                Write("{0}:", q);

                if(str1 != null)
                {
                    WriteLine("'" + str1 + "'");
                }
                else
                {
                    WriteLine("It is not a string");
                }
            }
        }
    }
    public class Exercises
    {
        public void Box()
        {
            int i = 1;
            object o = i;
            o = "i";
            string s = (string)o;
            WriteLine("i: " + i + "\n" +
                      "o: " + o + "\n" +
                      "s: " + s);
        }

        public void OperatorPrecedence()
        {
            decimal a = 5, b = 6, c = 7;
            WriteLine("a + b * c: " + (a + b * c));
            WriteLine("(a + b) * c: " + ((a + b) * c));
            WriteLine("a + (b * c): " + (a + (b * c)));
        }

         /*-6. Write a short program to showcase a query expression with the help of contextual keywords.*/
        /*ContextualKeywords:
         -add
         -remove
         -async
         -await
         -dynamic
         -get
         -global
         -group
         -into
         -partial
         -set
         -value
         -var
         -when
         -where
         -yield
         from
         -group
         -into
         -join
         -let
         orderby
         select
         where
         ascending
         descending
         -by
         in
         -on
         -equals
         */
        public void ContextualKeywords()
        {
            //from, orderby, select, ascending, descending, in, orderby, where
            string[] autos = new[] { "Peugeot", "Toyota", "Honda", "Fiat" };
            IEnumerable<string> autosSortAsc =
                from auto in autos
                where auto.Length > 4
                orderby auto ascending
                select auto;

            //List<string> cars = new List<string>();
            //cars[0] = "Audi";
            //cars[1] = "Vauxhall";
            //cars[2] = "Maserati";

            IEnumerable<string> autosSortDesc =
                from auto in autos
                orderby auto.Length descending
                select auto;

            var autosGroupBy =
                from auto in autos
                group auto by auto.Length into g
                orderby g.Key descending
                select g;

            Write("autosSortAsc: \n");
            foreach (string auto in autosSortAsc)
                Write(auto + "\n");

            Write("\nautosSortDesc: \n");
            foreach (string auto in autosSortDesc)
                Write(auto + "\n");

            Write("\nautosGroupBy: \n");
            foreach (var auto in autosGroupBy)
                Write(auto.ToString());
        }

        /*13. Define type conversion with the help of a short program.*/
        /*14. Write a short program that uses all the available built-in C# types and perform casting using the conversion method (decimal to int conversion can be achieved using var result = Convert.ToInt32(5689.25);).*/
        public void Conversion()
        {
            WriteLine("13. & 14.:");

            sbyte a = -1;
            short b = -200;
            int c = 22000000;
            long d = 30000000;
            byte e = 1;

            a = (sbyte)b;
            c = (int)d;
            e = (byte)a;
            WriteLine(a + " " + c + " " + e);

            ushort f = 65000;
            uint g = 30000000;
            ulong h = 30000000;

            f = (ushort)g;
            g = (uint)h;
            WriteLine(f + " " + g);

            float j = 1.5F;
            double k = 1.555D;
            decimal l = 1.55555M;

            j = (float)k;
            k = (double)l;
            WriteLine(j + " " + k);

            bool m = true;
            char i = 'c';
            string s = "s";
            s = m.ToString();
            WriteLine(s);
        }

        /*16. Write a program to elaborate each statement category.*/
        public void Statements()
        {
            string s = "*";
            WriteLine("Choose one option: ");
            WriteLine("1. Make x stars");
            WriteLine("2. Exit");
            var key = ReadLine();
            if (key == "1")
                {
                    WriteLine("Input no of stars:");
                    int no = Convert.ToInt32(ReadLine());
                    for (int i = 0; i <= no; i++)
                    {   
                        for(int j = 0; j <= i; j++)
                        {
                            Write(s);
                        }
                    Write("\n");
                    }
                    WriteLine("Press 'q' to quit");
                }
            else if (key == "2")
            {
                WriteLine("Bye bye!");
            }
            else
            {
                Statements();
            }
        }

        /*17. What are jump statements? Write a small program to showcase all jump statements.*/
        public void JumpStatements()
        {
            WriteLine("\nJump Statements \nChoose from below:");
            WriteLine("1 - Case1 \n2 - Case2 \n3 - Case3");
            int choice = 0;
            try
            {
                choice = int.Parse(ReadLine());
            }
            catch(Exception)
            {
                WriteLine("Please insert int value");
                JumpStatements();
            }

            switch (choice)
            {
                case 1:
                    WriteLine("Case1");
                    break;
                case 2:
                    WriteLine("Case2");
                    break;
                case 3:
                    WriteLine("Case3");
                    break;
                default:
                    for(int i = 0; i < choice; i++)
                    {
                        WriteLine("Default text");
                        continue;
                    }
                    WriteLine("After continue");
                    break;
            }
        }

        /*18. What is an array in C#?*/
        public void ArrayEx()
        {
            WriteLine("\nArray");
            string[] citiesJap = new string[3] { "Tokio", "Kobe", "Yokohama" };
            string[] citiesUS = new string[3] { "LA", "Detroit", "San Francisco"};
            string[] copy = new string[5];
            WriteLine("Array copy: ");
            foreach (var element in copy)
            {
                WriteLine(element);
            }
            Array.Copy(citiesJap, copy, 3);
            WriteLine("\nArray after Jap copy: ");
            foreach (var element in copy)
            {
                WriteLine(element);
            }
            Array.Copy(citiesUS, copy, 3);
            WriteLine("\nArray after US copy: ");
            foreach (var element in copy)
            {
                WriteLine(element);
            }
            ArraySort(copy);
        }

        public void ArraySort(string[] arrayToSort)
        {
            string[] _arrayToSort = arrayToSort;
            WriteLine("arrayToSort");
            Array.Sort(arrayToSort);
            foreach (var element in arrayToSort)
            {
                WriteLine(element);
            }
        }

        /*24. Refer to the System.String class and explore all its methods and properties with the help of a short program.*/

        public string word = "begin";
        StringBuilder sb = new StringBuilder();

        public void StringMethods()
        {
            // string - immutable; every changes results in new string Object
            WriteLine("word.GetHashCode(): " + word.GetHashCode());
            word = "second";
            WriteLine("word.GetHashCode(): " + word.GetHashCode());

            // StringBuilder - mutable; changes are made on same Object
            WriteLine("sb.GetHashCode(): " + sb.GetHashCode());
            sb.Append("begin");
            WriteLine("sb.GetHashCode(): " + sb.GetHashCode());

            string sentence = "the quick brown fox jumps over the lazy dog";
        
            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Aggregate all words from 'sentence;
            string aggregate = words.Aggregate((start, next) => start + next);
            WriteLine("aggregate:" + aggregate);

            // Check: all words Contain 'a'
            bool cond = words.All(param => param.Contains('a'));
            WriteLine("cond: " + cond);

            // Check: any words Contain 'a'
            bool result = words.Any(val => val.Contains('b'));
            WriteLine("result: " + result);

            //word.Append<>;
            //word.AsEnumerable<>;
            //word.AsParallel;
            //word.AsParallel<>;
            //word.AsQueryable;
            //word.AsQueryable<>;
            //word.Average<>;
            //word.Cast<>;
            //word.Clone;
            //word.CompareTo;
            //word.Concat<>;
            //word.Contains;
            //word.Contains<>;
            //word.CopyTo;
            //word.Count<>;
            /*word.DefaultIfEmpty;
            word.Distinct;
            word.ElementAt;
            word.ElementAtOrDefault;
            word.EndsWith;
            word.Equals;
            word.Except;
            word.First;
            word.FirstOrDefault;
            word.GetEnumerator;
            word.GetType;
            word.GetTypeCode;
            word.GroupBy;
            word.GroupJoin;
            word.IndexOf;
            word.IndexOfAny;
            word.Insert;
            word.Intersect;
            word.Last;
            word.LastIndexOf;
            word.LastIndexOfAny;
            word.LastOrDefault;
            word.Length;
            word.LongCount;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;
            word.;*/

        }

        /*32. Write a short program to prove that, explicitly, type conversion leads to data loss.*/
        public void TypeConvert()
        {
            int one = 1;
            int two = 2;
            string three = string.Empty;

            three = (one.ToString() + two.ToString());
            WriteLine("TypeConvert(): " + three);
        }
    }

    /*7. Write a short program to showcase the importance of the this and base keywords.*/
    public class Bank
    {
        public string Name = "";

        /* 9. Write a short program to prove that pointer type variable stores the memory of another variable rather than data.*/
        public void Pointer()
        {
            unsafe
            {
                int ten = 10;
                int twenty = 20;
                int* pointerVariable = &ten;
                WriteLine("Pointer val: " + ten);
                WriteLine("Pointer pointerVariable -> ToString(): " + pointerVariable -> ToString());
                WriteLine("Pointer (int)pointerVariable (=address): " + (int)pointerVariable);
                //+ cannot be applied to int* and int*
                //WriteLine(pointerVariable + pointerVariable);
            }
        }
    }

    public class BankClients : Bank
    {
        public string Name = "";

        public void ShowNames()
        {
            this.Name = "Tesco";
            base.Name = "Idea Bank";

            WriteLine("Name " + Name);
            WriteLine("Name " + base.Name);
        }
    }

    /*11.What is operator overloading? Write a short program to showcase operator overloading in action.*/
    public class Fraction
    {
        int num, den;
        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        // overload operator +
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den,
               a.den * b.den);
        }

        // overload operator *
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }

        // user-defined conversion from Fraction to double
        public static implicit operator double(Fraction f)
        {
            return (double)f.num / f.den;
        }
    }

    //Doesn't work - should multiply when + is used
    public class SubMulti
    {
        public int a, b, value;
        public SubMulti(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static SubMulti operator +(SubMulti x)
        {
            SubMulti submulti = new SubMulti(x.a, x.b);
            submulti.value = x.a * x.b * (-1);
            return submulti;
        }
    }

    public class Widget
    {
        public int value;

        public static Widget operator +(Widget x, Widget y)
        {
            Widget widget = new Widget();
            widget.value = x.value * y.value;
            return widget;
        }
    }

    /*29. Write a small program and showcase the differences between a struct and a class.*/
    public class Store : Network
    {
        public struct Book : IItem
        {
            public string title;
            public string author;
        }

        public struct Item
        {
            public int price;
            public string category;
        }

        public void ClassAndStruct()
        {
            Store storeNY = new Store();
            Store storeLA = storeNY;
            storeNY.name = "New Yorker";
            storeLA.name = "LA Stars";
            WriteLine("storeNY: " + storeNY.name);
            WriteLine("storeLA: " + storeLA.name);
            Sale amount2018 = new Sale();
            Sale amount2019 = amount2018;
            amount2018.amount = 1000;
            amount2019.amount = 2000;
            WriteLine("amount2018: " + amount2018.amount);
            WriteLine("amount2019: " + amount2019.amount);
        }
    }

    public struct Sale
    {
        public int amount;
    }

    public class Network
    {
        public string name; 
    }

    public interface IItem
    {

    }

    /*31. Write a program to show the difference between compile-time type and runtime type.*/
    class Animal { }
    class Dog : Animal { }
    class Cat : Animal { }
}
/*Exercises
 1. Write a short program to demonstrate that we can use same class name within different namespaces.
 2. Define the console class. Write a console program to display all available colors by modifying the code example discussed in the book so that all vowels will be displayed as green and all consonants as blue.
 3. Elaborate on C# reserved keywords.
 4. Describe different categories of C# keywords with examples. 
 5. Create a small program to demonstrate the is and as operators.
 
-6. Write a short program to showcase a query expression with the help of contextual keywords.

 7. Write a short program to showcase the importance of the this and base keywords.
 8. Define boxing and unboxing with the help of a short program.
 9. Write a short program to prove that pointer type variable stores the memory of another variable rather than data.
 10. Write a short program to showcase the operator precedence order.
 11. What is operator overloading? Write a short program to showcase operator overloading in action.
 12. What are the operators that cannot be overloaded and why?
 &&, ||, [], (T)x, +=, -=, *=, /=, %= &=, |=, ^=, <<=, >>=, =, ., ?:, ??, ->, =>, f(x), 
 as, checked, unchecked, default, unchecked, default, delegate, is, new, sizeof, typeof
 13. Define type conversion with the help of a short program.
 14. Write a short program that uses all the available built-in C# types and perform casting using the conversion method (decimal to int conversion can be achieved using var result = Convert.ToInt32(5689.25);).
 15. Define C# statements.
 16. Write a program to elaborate each statement category.
 17. What are jump statements? Write a small program to showcase all jump statements.
 18. What is an array in C#?
 19. Write a program and prove that an array is a block of contiguous memory.
 20. Refer to System.Array class (https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-2.0) and write a short program.
 21. Pass an array as a parameter to a method.
 22. Sort the array.
 23. Copy the array.

 -24. Refer to the System.String class and explore all its methods and properties with the help of a short program.
 -25. How are string objects immutable? Write a short program to showcase this.
 -26. What are string builders?
 
 27. What is a class?
 28. What is a structure?
 29. Write a small program and showcase the differences between a struct and a class. 
 //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/index
 30. Explain compile-time type and runtime type.
 31. Write a program to show the difference between compile-time type and runtime type.
 32. Write a short program to prove that, explicitly, type conversion leads to data loss.
 
*/

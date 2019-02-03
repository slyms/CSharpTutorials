using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;

namespace Day02Ex
{
    public class Exercices
    {
        public void ExerciseMethod(int x, int y)
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
            1. Same class name within different namespaces
            int x, y;
            WriteLine("Enter two numbers: ");
            x = Convert.ToInt32(ReadLine());
            y = Convert.ToInt32(ReadLine());
            Day02Ex.Exercices exercices = new Day02Ex.Exercices();
            exercices.ExerciseMethod(x, y);
            Day02Ex_Second.Exercices exercicesSecond = new Day02Ex_Second.Exercices();
            exercicesSecond.ExercisesMethod(x, y);
            2. Console colors - display vowels as green, and consonants as blue
            Console.ConsoleOperationExamples();
            5. Create a small program to demonstrate the is and as operators
            GFG.IsOperator();
            GFG.AsOperator();
            8. Define boxing and unboxing with the help of a short program.
            Exercises box = new Exercises();
            box.Box();
            10. Write a short program to showcase the operator precedence order.
            */
            Exercises op = new Exercises();
            op.OperatorPrecedence();
            /*6. Write a short program to showcase a query expression with the help of contextual keywords.*/
            op.ContextualKeywords();
            /*7.Write a short program to showcase the importance of the this and base keywords.*/
            BankClients bankClients = new BankClients();
            bankClients.ShowNames();
            Bank bank = new Bank();
            bank.Pointer();
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
            P instance1 = new P();
            P1 instance2 = new P1();
            WriteLine("instance1 is P: " + (instance1 is P));
            WriteLine("instance1 is P1: " + (instance1 is P1));
            WriteLine("instance1 is P2: " + (instance1 is P2));
            WriteLine("instance1 is Object: " + (instance1 is Object));
            WriteLine("instance2 is P: " + (instance2 is P));
            WriteLine("instance2 is P1: " + (instance2 is P1));
            WriteLine("instance2 is P2: " + (instance2 is P2));
            WriteLine("instance2 is Object: " + (instance2 is Object));
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
         -where
         ascending
         descending
         -by
         in
         -on
         -equals
         */
        public void ContextualKeywords()
        {
            string[] autos = new[] { "Peugeot", "Toyota", "Honda", "Fiat"};
            IEnumerable<string> autosSortAsc =
                from auto in autos
                orderby auto ascending
                select auto;

            IEnumerable<string> autosSortDesc =
                from auto in autos
                orderby auto descending
                select auto; 

            Write("autosSortAsc: \n");
            foreach(string auto in autosSortAsc)
                Write(auto + "\n");

            Write("autosSortDesc: \n");
            foreach (string auto in autosSortDesc)
                Write(auto + "\n");
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
}
/*Exercises
 1. Write a short program to demonstrate that we can use same class name within different namespaces.
 2. Define the console class. Write a console program to display all available colors by modifying the code example discussed in the book so that all vowels will be displayed as green and all consonants as blue.
 3. Elaborate on C# reserved keywords.
 4. Describe different categories of C# keywords with examples. 
 5. Create a small program to demonstrate the is and as operators.

 7. Write a short program to showcase the importance of the this and base keywords.
 8. Define boxing and unboxing with the help of a short program.
 9. Write a short program to prove that pointer type variable stores the memory of another variable rather than data.
 10. Write a short program to showcase the operator precedence order.
 
 -6. Write a short program to showcase a query expression with the help of contextual keywords.
 -11. What is operator overloading? Write a short program to showcase operator overloading in action.
 -12. What are the operators that cannot be overloaded and why?
 -13. Define type conversion with the help of a short program.
 -14. Write a short program that uses all the available built-in C# types and perform casting using the conversion method (decimal to int conversion can be achieved using var result = Convert.ToInt32(5689.25);).
 -15. Define C# statements.
 -16. Write a program to elaborate each statement category.
 -17. What are jump statements? Write a small program to showcase all jump statements.
 -18. What is an array in C#?
 -19. Write a program and prove that an array is a block of contiguous memory.
 -20. Refer to System.Array class (https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-2.0) and write a short program.
 -21. Pass an array as a parameter to a method.
 -22. Sort the array.
 -23. Copy the array.
 -24. Refer to the System.String class and explore all its methods and properties with the help of a short program.
 -25. How are string objects immutable? Write a short program to showcase this.
 -26. What are string builders?
 -27. What is a class?
 -28. What is a structure?
 -29. Write a small program and showcase the differences between a struct and a class. 
 -30. Explain compile-time type and runtime type.
 -31. Write a program to show the difference between compile-time type and runtime type.
 -32. Write a short program to prove that, explicitly, type conversion leads to data loss.
*/

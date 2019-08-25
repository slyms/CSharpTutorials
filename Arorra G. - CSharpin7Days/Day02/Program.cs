using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

/*1. Classes can have similar names - if used in different namespaces */
namespace Day02First
{
    public class ClassExample
    {
        public void Display()
        {
            WriteLine("Day02: Hello World!");
        }
    }
}

namespace Day02Second
{
    public class ClassExample
    {
        public void Display()
        {
            WriteLine("Day02New: Hello World!");
        }

        public int go;
    }
}

namespace Day02
{
    public class Gun
    {
        public string gunName = "Machine gun";
    }

    public class M9 : Gun
    {
        public string gunMark = "M9";
    }

    internal class Program
    {
        private static void Main()
        {
            /*
            var gunC = new M9();
            WriteLine("gunC.gunName " + gunC.gunName);
            WriteLine("gunC.gunMark " + gunC.gunMark);

            gunC.gunName = "Change";

            M9 gunM9 = new M9();
            WriteLine("gunM9.gunName " + gunM9.gunName);
            WriteLine("gunM9.gunMark " + gunM9.gunMark);

            Gun gunG = new M9();
            WriteLine("gunG.gunName " + gunG.gunName);
            //WriteLine(gunG.gunMark);

            var gunP = new Gun { gunName = "M15" };
            WriteLine("gunP.gunName " + gunP.gunName);
            //WriteLine(gunP.gunMark);

            Gun gunM9G = new Gun { gunName = "M15" };
            WriteLine("gunM9G.gunName " + gunM9G.gunName);
            //M9 m9 = (M9)gunM9G; //Cast Excep
            //WriteLine("m9.gunName " + m9.gunName);
            //WriteLine(gunM9G.gunMark);

            Gun gunPG = new Gun { gunName = "M15" };
            WriteLine("gunPG.gunName " + gunPG.gunName);
            //WriteLine(gunPG.gunMark);

            WriteLine("Day02 - Learn C# in 7-days");

            SameClassDifferentNamespacesExample();
            ConsoleOperationExamples();
            ConsoleBeepExample();
            */

            //Don't understand it
            //IsAsOperatorExample();
            //UsingExample();
            
            /*
            CheckOverFlowExample();
            SizeofExample();
            TypeofExample();
            DynamicTypeExample();
            Day02CST.CSharpType.Display();
            BoxingUnboxingExample();
            OperatorExample();
            OperatorOverloadingExample();
            ImplicitExplicitTypeConversionExample();
            IsAsOperatorExample();
            StatementExample();
            IfStatementExample();
            IfElseStatementExample();
            IfElseIfElseStatementExample();
            NestedIfStatementExample();
            SwitchCaseExample();
            DoWhileStatementExample();
            WhileStatementExample();
            ForStatementExample();
            ForEachStatementExample();
            BreakStatementExample();
            ContinueStatementExample();
            
            */
            ArrayExample();
            /*
            StringExample();
            StructureExample();
            */
        }

        #region Finished
        /*1. Classes can have similar names - if used in different namespaces */
        private static void SameClassDifferentNamespacesExample()
        {
            var class1 = new Day02First.ClassExample();
            var class2 = new Day02Second.ClassExample();
            class1.Display();
            class2.go = 1;
            class2.Display();
            ReadLine();
        }

        /*2. Console colors */
        private static void ConsoleOperationExamples()
        {
            WriteLine("Console Color example\n");
            var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            WriteLine("All available colors");
            (int background, int foreground) userInput;
            do
            {
                userInput = DisplayColorMenu(colors);
                if (userInput.foreground == colors.Length + 1 || userInput.background == colors.Length + 1)
                {
                    WriteLine("Resetting to default...");
                    ResetColor();
                    Write("Press any key to continue...");
                    ReadLine();
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.foreground < 0 || userInput.background < 0)
                {
                    WriteLine("-ve values are not allowed");
                }
                else if (userInput.background == colors.Length + 2 || userInput.foreground == colors.Length + 2)
                {
                }
                else
                {
                    BackgroundColor = colors[userInput.background];
                    ForegroundColor = colors[userInput.foreground];

                    WriteLine($"Foreground color is {ForegroundColor}");
                    WriteLine($"Background color is {BackgroundColor}");
                    WriteLine();

                    Write("Type anything to see the changes:");
                    ReadLine();
                }
            }
            while (userInput.background != colors.Length + 2 || userInput.foreground != colors.Length + 2);
        }

        private static (int, int) DisplayColorMenu(ConsoleColor[] colors)
        {
            var count = 0;

            foreach (var color in colors)
            {
                WriteLine($"{count} {color}");
                count += 1;
            }
            WriteLine($"{count + 1} Reset");
            WriteLine($"{count + 2} Exit");

            Write("Choose Foreground color:");
            var foreground = Convert.ToInt32(ReadLine());
            Write("Choose Background color:");
            var background = Convert.ToInt32(ReadLine());

            return new ValueTuple<int, int>(background, foreground);
        }

        /*3. Beep */
        private static void ConsoleBeepExample()
        {
            for (var i = 0; i < 9; i++)
                Beep();
        }

        /*4. Is As */
        private static void IsAsOperatorExample()
        {
            //Object of Author Name
            WriteLine("isas Operator");
            var author = new Author { Name = "Gaurav Aroraa" };

            var contmember = new ContentMember("John");
            contmember.GetContentMemberName();
            var teammember = new TeamMember { Name = "Jill" };
            contmember.GetContentMemberName();
            //Declare Object of Stackholder Class
            var stackholder = new Stackholder();

            WriteLine("Author name using as:");
            //Using "get" property to get Author Name
            stackholder.GetAuthorName(author);

            WriteLine("\nAuthor name using is:");
            stackholder.GetStackholdersName(author);
            stackholder.GetStackholdersName(teammember);
            stackholder.GetStackholdersName(contmember);

            //stackholder.GetStackholdersName(contentMember);
            ReadLine();
        }

        /*5. OverFlow */
        private static void CheckOverFlowExample()
        {
            //int sumWillThrowError = 2147483647 + 19; //Compile time Error

            var maxValue = int.MaxValue;
            var addSugar = 19;
            var sumWillNotThrowError = maxValue + addSugar;
            WriteLine($"Sum value: {sumWillNotThrowError} is not the correct value, because it is larger than {maxValue}");

            const int maxValueInt = int.MaxValue;
            const int addSugarInt = 19;
            //sumWillNotThrowError = maxValueInt + addSugarInt; //Overflow
            //sumWillNotThrowError = checked(maxValueInt + addSugarInt); //Overflow
            sumWillNotThrowError = unchecked(maxValueInt + addSugarInt);
            //sumWillNotThrowError - exceeds max positive value of int
            WriteLine($"Sum value: {sumWillNotThrowError} is not the correct value, because it is larger than {maxValueInt}");
            ReadLine();
        }

        /*6. sizeof */
        private static void SizeofExample()
        {
            WriteLine("Various in-built types have size as mentioned below:\n");
            WriteLine($"The size of data type int is: {sizeof(int)}");
            WriteLine($"The size of data type long is: {sizeof(long)}");
            WriteLine($"The size of data type double is: {sizeof(double)}");
            WriteLine($"The size of data type bool is: {sizeof(bool)}");
            WriteLine($"The size of data type short is: {sizeof(short)}");
            WriteLine($"The size of data type byte is: {sizeof(byte)}");
        }

        /*7. typeof */
        private static void TypeofExample()
        {
            var thisIsADouble = 30.3D;
            WriteLine("using typeof()");
            WriteLine($"System.Type Object of {nameof(Program)} is {typeof(Program)}\n");
            var objProgram = new Program();
            WriteLine("using GetType()");
            WriteLine($"System.Type Object of {nameof(objProgram)} is {objProgram.GetType()}");
            WriteLine($"System.Type Object of {nameof(thisIsADouble)} is {thisIsADouble.GetType()}");
        }

        /*8. Using/Disposable */
        public static void UsingExample()
        {
            using (var disposableClass = new DisposableClass())
            {
                WriteLine($"{disposableClass.GetMessage()}");
            }
        }

        /*9. DynamicType */
        private static void DynamicTypeExample()
        {
            dynamic dynamicInt = 10;
            dynamic dynamicString = "This is a dynamic string";
            object obj = 10;
            WriteLine($"Run-time type of {nameof(dynamicInt)} is {dynamicInt.GetType()}");
            WriteLine($"Run-time type of {nameof(dynamicString)} is {dynamicString.GetType()}");
            WriteLine($"Run-time type of {nameof(obj)} is {obj.GetType()}");
        }

        /*11. Boxing & Unboxing */
        private static void BoxingUnboxingExample()
        {
            //Declare int value
            int thisIsValueTypeVariable = 786;
            //Create Object Type Variable = Boxing
            object thisIsObjectTypeVariable = thisIsValueTypeVariable; //Boxing
            //Increment value by 1
            thisIsValueTypeVariable += 1;
            WriteLine("Boxing");
            WriteLine($"Before Boxing: Value of {nameof(thisIsValueTypeVariable)}: {thisIsValueTypeVariable}");
            WriteLine($"After Boxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");

            //Declare int value
            thisIsObjectTypeVariable = 1900;
            //Cast Object Type Variable to Value Type Variable = Unboxing
            thisIsValueTypeVariable = (int)thisIsObjectTypeVariable; //Unboxing
            WriteLine("UnBoxing");
            WriteLine($"Before Unboxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");
            WriteLine($"After Unboxing: Value of {nameof(thisIsValueTypeVariable)}: {thisIsValueTypeVariable}");
        }

        /*12. Operator */
        private static void OperatorExample()
        {
            WriteLine("Operators example\n");
            var csharpOperator = new CSharpOperator();
            Write("Enter first number:");
            csharpOperator.Num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number:");
            csharpOperator.Num2 = Convert.ToInt32(ReadLine());
            Clear();
            csharpOperator.Display();
        }

        /*13. Operator Overloading */
        private static void OperatorOverloadingExample()
        {
            WriteLine("Operator overloading example\n");
            Write("Enter x-axis of Surface1: ");
            var x1 = ReadLine();
            Write("Enter y-axis of Surface1: ");
            var y1 = ReadLine();
            Write("Enter x-axis of Surface2: ");
            var x2 = ReadLine();
            Write("Enter y-axis of Surface2: ");
            var y2 = ReadLine();

            //Create Object structure
            var surface1 = new Coordinate(Convert.ToInt32(x1), Convert.ToInt32(y1));
            var surface2 = new Coordinate(Convert.ToInt32(x2), Convert.ToInt32(y2));
            WriteLine();
            Clear();
            WriteLine($"Surface1:{surface1}");
            WriteLine($"Area of Surface1:{surface1.Area()}");
            WriteLine($"Surface2:{surface2}");
            WriteLine($"Area of Surface2:{surface2.Area()}");
            WriteLine();
            WriteLine($"surface1 == surface2: {surface1 == surface2}");
            WriteLine($"surface1 < surface2: {surface1 < surface2}");
            WriteLine($"surface1 > surface2: {surface1 > surface2}");
            WriteLine($"surface1 <= surface2: {surface1 <= surface2}");
            WriteLine($"surface1 >= surface2: {surface1 >= surface2}");
            WriteLine();
            var surface3 = surface1 + surface2;
            WriteLine($"Addition: {nameof(surface1)} + {nameof(surface2)} = {surface3}");
            WriteLine($"{nameof(surface3)}:{surface3}");
            WriteLine($"Area of {nameof(surface3)}: {surface3.Area()} ");
            WriteLine();
            WriteLine($"Substraction: {nameof(surface1)} - {nameof(surface2)} = {surface1 - surface2}");
            WriteLine($"Multiplication: {nameof(surface1)} * {nameof(surface2)} = {surface1 * surface2}");
            WriteLine($"Division: {nameof(surface1)} / {nameof(surface2)} = {surface1 / surface2}");
            WriteLine($"Modulus: {nameof(surface1)} % {nameof(surface2)} = {surface1 % surface2}");
        }

        /*14. Implicit Explicit Type Conversion*/
        private static void ImplicitExplicitTypeConversionExample()
        {
            WriteLine("Implicit conversion");
            int numberInt = 2589;
            double doubleNumber = numberInt; //Implicit type conversion

            WriteLine($"{nameof(numberInt)} of type: {numberInt.GetType().FullName} has value: {numberInt}");
            WriteLine($"{nameof(doubleNumber)} of type: {doubleNumber.GetType().FullName} implicitly type casted and has value: {numberInt}");

            WriteLine("Implicit conversion");
            doubleNumber = 2589.05D;
            numberInt = (int)doubleNumber; //Explicit
            WriteLine($"{nameof(doubleNumber)} of type: {doubleNumber.GetType().FullName} has value: {doubleNumber}");
            WriteLine($"{nameof(numberInt)} of type: {numberInt.GetType().FullName} explicitly type casted and has value: {numberInt}");
        }

        /*15. Statement*/
        private static void StatementExample()
        {
            WriteLine("Statement example");
            int singleLineStatement; //Declarative statement
            WriteLine("'int singleLineStatement;' is a declarative statement");
            singleLineStatement = 125; //Assignment statement
            WriteLine("'singleLineStatement = 125;' is an assignment statement");
            WriteLine($"{nameof(singleLineStatement)} = {singleLineStatement}");
            var persons = new List<Person>
            {
                new Author
                {
                    Name = "Gaurav Aroraa"
                }
            }; //Declarative and assignment statement
            WriteLine("'var persons = new List<Person>();' is a declarative and assignment statement"); //Block statement
            foreach (var person in persons)
            {
                WriteLine("'foreach (var person in persons){}' is a block statement");
                WriteLine($"Name: {person.Name}");
            }
        }

        /*16. If*/
        private static void IfStatementExample()
        {
            WriteLine("If statement example");
            WriteLine("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());

            //Many If statements - Compiler goes through all of them
            //Not recommended
            if (char.ToLower(inputChar) == 'a')
                WriteLine($"Character {inputChar} is a vowel");
            if (char.ToLower(inputChar) == 'e')
                WriteLine($"Character {inputChar} is a vowel");
            if (char.ToLower(inputChar) == 'i')
                WriteLine($"Character {inputChar} is a vowel");
            if (char.ToLower(inputChar) == 'o')
                WriteLine($"Character {inputChar} is a vowel");
            if (char.ToLower(inputChar) == 'u')
                WriteLine($"Character {inputChar} is a vowel");
            if (char.ToLower(inputChar) == 'y')
                WriteLine($"Character {inputChar} is a vowel");
        }

        /*17. If Else*/
        private static void IfElseStatementExample()
        {
            WriteLine("If else statement example");
            WriteLine("Enter character: ");
            char inputChar = Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            if (vowels.Contains(char.ToLower(inputChar)))
                WriteLine($"Character '{inputChar}' is a vowel");
            else
                WriteLine($"Character '{inputChar}' is a consonant");
        }

        /*18. If Else If Else*/
        private static void IfElseIfElseStatementExample()
        {
            WriteLine("If else if else statement example");
            WriteLine("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());

            if (char.ToLower(inputChar) == 'a')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else if (char.ToLower(inputChar) == 'e')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else if (char.ToLower(inputChar) == 'i')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else if (char.ToLower(inputChar) == 'o')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else if (char.ToLower(inputChar) == 'u')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else if (char.ToLower(inputChar) == 'y')
            { WriteLine($"Character '{inputChar}' is a vowel"); }
            else
            { WriteLine($"Character '{inputChar}' is a consonant"); }
        }

        /*19. Nested If Else*/
        private static void NestedIfStatementExample()
        {
            WriteLine("Nested If statement example");
            Write("Enter your age:");
            int age = Convert.ToInt32(ReadLine());

            if (age < 18)
            {
                WriteLine("Your age should be equal or greater than 18yrs");
                if (age < 15)
                {
                    WriteLine("You need to complete your school first");
                }
            }
            else
                Write("You're smart ;)");
        }

        /*20. Switch*/
        private static void SwitchCaseExample()
        {
            WriteLine("Switch case statement example");
            Write("Enter character: ");
            char inputChar = Convert.ToChar(ReadLine());

            switch (char.ToLower(inputChar))
            {
                case 'a':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                case 'e':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                case 'i':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                case 'o':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                case 'u':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                case 'y':
                    WriteLine($"Character {inputChar} is a vowel");
                    break;
                default:
                    WriteLine($"Character {inputChar} is a consonant");
                    break;
            }
        }

        /*Iteration*/
        /*21. do...while*/
        private static void DoWhileStatementExample()
        {
            WriteLine("do...while example");
            Write("Enter repetitive length: ");
            int length = Convert.ToInt32(ReadLine());
            int count = 0;
            do
            {
                count++;
                WriteLine(new string('*', count));
            }
            while (count < length);
        }

        /*22. while*/
        private static void WhileStatementExample()
        {
            WriteLine("while example");
            Write("Enter repetitive length: ");
            int length = Convert.ToInt32(ReadLine());
            int count = 0;
            while (count < length)
            {
                count++;
                WriteLine(new string('*', count));
            }
        }

        /*23. for*/
        private static void ForStatementExample()
        {
            WriteLine("for loop example");
            Write("Enter repetitve length: ");
            int length = Convert.ToInt32(ReadLine());
            for(int countIndex = 0; countIndex < length; countIndex++)
            {
                WriteLine(new string('*', countIndex));
            }
        }

        /*24. foreach*/
        private static void ForEachStatementExample()
        {
            WriteLine("foreach loop example");
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y' };
            WriteLine("foreach on Array");
            foreach(var vowel in vowels)
            {
                WriteLine($"{vowel}");
            }
            WriteLine();
            var persons = new List<Person>
            {
                new Author { Name = "Gaurav Aroraa"},
                new Reviewer { Name = "Shivprasad Koirala"},
                new TeamMember { Name = "Vikas Tiwari"},
                new TeamMember { Name = "Denim Pinto"}
            };
            WriteLine("foreach on collection");
            foreach (var person in persons)
            {
                WriteLine($"{person.Name}");
            }
        }

        /*25. break*/
        private static void BreakStatementExample()
        {
            WriteLine("break statement example");
            WriteLine("break in for loop");
            for (int count = 0; count < 50; count++)
            {
                if (count == 8)
                {
                    break;
                }
            WriteLine($"{count}");
            }
            WriteLine();
            WriteLine("break in switch statement");
            SwitchCaseExample();
        }

        /*26. continue / jump*/
        private static void ContinueStatementExample()
        {
            WriteLine("continue statement example");
            WriteLine("continue in for loop");
            for (int count = 0; count < 15; count ++)
            {
                if(count < 8)
                {
                    continue; //because of continue, WriteLine doesn't execute for count < 8
                }
                WriteLine($"{count}");
            }
        }

        /*27. Array*/
        private static void ArrayExample()
        {
            WriteLine("Array example\n");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y'};
            WriteLine("char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y'};\n");
            WriteLine("access array using for loop");
            for(int rankIndex = 0; rankIndex < vowels.Length; rankIndex++)
            {
                Write($"{vowels[rankIndex]} ");
            }
            WriteLine();
            WriteLine("access array using foreach loop");
            foreach(char vowel in vowels)
            {
                Write($"{vowel} ");
            }
            WriteLine();

            /*Single-dimension*/
            string[] cardinalDirections = { "North", "East", "South", "West"};

            /*Multidimensional*/
            int[,] numbersSquare = new int[2, 2];
            int[,] numbers = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            /*Get rows*/
            for(int rowsIndex = 0; rowsIndex < 2; rowsIndex++)
            {
                /*Get cols*/
                for (int colIndex = 0; colIndex < 2; colIndex++)
                {
                    WriteLine($"numbers[{rowsIndex}, {colIndex}] = {numbers[rowsIndex, colIndex]}");
                }
            }

            /*Jagged*/
            /*Jagged array of 3 elements that contain a two-dimensional array*/
            WriteLine("Jagged array \n");
            string[][,] collaborators = new string[3][,]
            {
                new[,] { {"Name", "Shivprasad Koirala"}, 
                         { "Age", "40"} },
                new[,] { {"Name", "Gaurav Aroraa"}, 
                         { "Age", "43"} },
                new[,] { {"Name", "Vikas Tiwari"}, 
                         { "Age", "28"} }
            };

            for(int index = 0; index < collaborators.Length; index++)
            {
                for (int rowIndex = 0; rowIndex < 2; rowIndex++)
                {
                    for(int colIndex = 0; colIndex < 2; colIndex++)
                    {
                        WriteLine($"collaborators[{index}][{rowIndex},{colIndex}] = {collaborators[index] [rowIndex,colIndex]}");
                    }
                }
            }
            ReadKey();
        }

        /*28. String */
        private static void StringExample()
        {
            WriteLine("String object creation - alternative ways");
            string authorName = "Gaurav Arorra"; //string literal assignment
            WriteLine($"{authorName}");
            string property = "Name: ";
            string person = "Gaurav";
            string personName = property + person; //string concatenation
            WriteLine($"{personName}");

            //define char array
            char[] language = { 'c', 's', 'h', 'a', 'r', 'p' };
            string strLanguage = new string(language); //initializing the Constructor
            WriteLine($"{strLanguage}");
            string repeatMe = new string('*', 5);
            WriteLine($"{repeatMe}");
            //define string array
            string[] members = { "Shivprasad", "Denim", "Vikas", "Gaurav" };
            string name = string.Join(" ", members);
            WriteLine($"{name}");
        }

        /*29. Struct */
        public struct BookAuthor
        {
            public string Name;
            public string BookTitle;
            public int Age;
            public string City;
            public string State;
            public string Country;

            public BookAuthor(string name, string bookTitle, int age, string city, string state, string country)
            {
                Name = name;
                BookTitle = bookTitle;
                Age = age;
                City = city;
                State = state;
                Country = country;
            }

            public override string ToString()
            {
                return $"Author {Name} is of {Age} yrs old from {City}, {State}, {Country} & has written book: '{BookTitle}'";
            }
        }

        public class ClassBookAuthor
        {
            public string Name;
            public string BookTitle;
            public int Age;
            public string City;
            public string State;
            public string Country;

            public ClassBookAuthor(string name, string bookTitle, int age, string city, string state, string country)
            {
                Name = name;
                BookTitle = bookTitle;
                Age = age;
                City = city;
                State = state;
                Country = country;
            }

            public override string ToString()
            {
                return $"Author {Name} is of {Age} yrs old from {City}, {State}, {Country} & has written book: '{BookTitle}'";
            }
        }

        private static void StructureExample()
        {
            WriteLine("Structure example\n");
            Write("Author name:");
            var name = ReadLine();
            Write("Book Title:");
            var bookTitle = ReadLine();
            Write("Author age:");
            var age = ReadLine();
            Write("Author city:");
            var city = ReadLine();
            Write("Author state:");
            var state = ReadLine();
            Write("Author country:");
            var country = ReadLine();

            BookAuthor author = new BookAuthor(name, bookTitle, Convert.ToInt32(age), city, state, country);
            WriteLine($"{author.ToString()}");
            BookAuthor author1 = author; //copy structure = copy only data as this is not a class

            Write("Change author name:");
            var name1 = ReadLine();
            author.Name = name1;

            WriteLine("Author1");
            WriteLine($"{author.ToString()}"); //Only this is changed
            WriteLine("Author2");
            WriteLine($"{author1.ToString()}");

            ClassBookAuthor author2 = new ClassBookAuthor(name, bookTitle, Convert.ToInt32(age),city,state,country);
            WriteLine($"{author2.ToString()}");
            ClassBookAuthor author3 = author2; //copy class = copy reference

            Write("Change author name:");
            var name2 = ReadLine();
            author2.Name = name2;

            WriteLine("Author1");
            WriteLine($"{author2.ToString()}"); //Changed
            WriteLine("Author2");
            WriteLine($"{author3.ToString()}"); //Changed
        }
        #endregion
    }
}
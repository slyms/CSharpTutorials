using System;

namespace WassimHam
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Lectures 1-5
            //LectureOneToFive();
            //LectureSix();
            //LectureSeven();
            //LectureEight();
            //LectureNine();

            string firstName = "Marty ";
            string secondName = "";

            string checkedFullName;
            if (firstName == "")
                checkedFullName = "error";
            else if (secondName == "")
                checkedFullName = "error";
            else
                checkedFullName = firstName + secondName;

            //Method Overload - pick 
            Console.WriteLine(LectureNine("Mr", "Marty", ""));

            //Exercices
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            //ExerciseFive();

            Console.WriteLine("Lecture Six: adding two ints. Below write two ints:");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine(ExerciseSix(firstInt, secondInt));

            Console.WriteLine("First, write two numbers.");
            
            firstInt = int.Parse(Console.ReadLine());
            secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Second, decide if you want to add (1) or substract (2) those numbers");
            int decisionInt = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }

        //Lectures 1-5
        public static void LectureOneToFive()
        {
            Console.WriteLine("Hello World!");

            //First program
            int x = 5;
            Console.WriteLine(x);
            x = x * 4;
            Console.WriteLine(x);

            //Data types
            bool trueFalse = false;
            int i = int.MaxValue;
            long l = long.MaxValue;
            float f = float.MaxValue;
            double d = double.MaxValue;

            //Data types - Conversion
            long l2 = i;
            //Cast - explicit conversion long to int
            int i2 = (int)l;
            double d2 = f;
            float f2 = (float)d;

            //ToString()
            int j = 5;

            string s = j.ToString();

            string t = Console.ReadLine();
            Console.WriteLine(t);
            Console.WriteLine(Console.ReadLine());

            //Parse()
            double dd = double.Parse(Console.ReadLine());
            double squareArea = dd * dd;

            Console.WriteLine(squareArea);

            //If
            string str = "hello";
            bool myBool = str.Contains("l");

            Console.WriteLine("myBool: " + myBool);

            Console.ReadLine();

            int z = 5;
            if (z < 4)
            {
                Console.WriteLine("Less than four");
            }
            else if (z > 4)
            {
                Console.WriteLine("Greater than four");
            }
            else
            {
                Console.WriteLine("Z equals 4");
            }


            int c = 10;

            if (c == 0)
                Console.WriteLine("zero");
            else if (c == 1)
                Console.WriteLine("one");
            else if (c == 2)
                Console.WriteLine("two");
            else if (c == 3)
                Console.WriteLine("three");
            else if (c == 4)
                Console.WriteLine("four");
            else
                Console.WriteLine("ugly number");

            //Switch
            switch (c)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 67:
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                default:
                    Console.WriteLine("ugly number");
                    break;
            }

            //Operators - AND & OR
            int a = 4;
            int b = 6;

            if ((a == 4 && b > 5) || (a < 3 && b == 7))
                Console.WriteLine("Hello again");
        }

        //Lecture 6 - Loops
        public static void LectureSix()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            string whileString = "Cakes";

            while (whileString.Length > 1)
            {
                whileString = whileString.Remove(whileString.Length - 1);
                Console.WriteLine("While result: " + whileString);
            }

            string doWhileString = "Cakes";

            do
            {
                doWhileString = doWhileString.Remove(doWhileString.Length - 1);
                Console.WriteLine("DoWhile result: " + doWhileString);
            }
            while (doWhileString.Length > 1);

        }

        //Lecture 7 - Array - One dimension
        public static void LectureSeven()
        {
            string[] oneArray = new string[5];

            //Assigning value
            oneArray[0] = "strawberry";
            oneArray[1] = "blueberry";
            oneArray[2] = "cranberry";
            oneArray[3] = "gooseberry";
            oneArray[4] = "raspberry";

            //Collection initializer
            string[] simpleArray = { "strawberry", "blueberry", "cranberry", "gooseberry", "raspberry" };

            //for loop - Get all elements from array
            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.WriteLine(simpleArray[i]);
            }

            Console.WriteLine(simpleArray[4]);
        }

        //Lecture 8 - Array - Multi dimension
        public static void LectureEight()
        {
            //Comma - indicates multi arrays
            //1st index is an array
            //2nd holds variables
            int[,] multiArray = new int[2, 3];

            multiArray[0, 0] = 1;
            multiArray[0, 1] = 2;
            multiArray[0, 2] = 3;

            multiArray[1, 0] = 4;
            multiArray[1, 1] = 5;
            multiArray[1, 2] = 6;

            //Collection initializer
            //Array of arrays - each curly bracket for an inside array
            int[,] simpleArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //1st for loop goes thru 1st dimension = (0)
            for (int i = 0; i < multiArray.GetLength(0); i++)
                //2n for loop is triggered with each iteration of the 1st loop - 2nd dimension = (1)
                for (int j = 0; j < multiArray.GetLength(1); j++)
                    Console.WriteLine("multiArray: " + multiArray[i, j]);

            //Array - jagged
            int[][] jaggedArray = new int[2][]; //[2] - size of 1st dimension
            //Child Arrays
            jaggedArray[0] = new int[3]; //length of Array
            jaggedArray[1] = new int[5];

            jaggedArray[0][0] = 1; //set Variables - 1st Array, 1st cell
            jaggedArray[0][1] = 2;
            jaggedArray[0][2] = 3;

            jaggedArray[1][0] = 4;
            jaggedArray[1][1] = 5;
            jaggedArray[1][2] = 6;
            jaggedArray[1][3] = 7;
            jaggedArray[1][4] = 8; //2nd Array, 5th cell

            //Collection initializer
            int[][] jaggedArray2 = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7, 8 };

            //Collection initializer - 2nd variant - parent Array level
            int[][] jaggedArray3 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6, 7, 8}
            };

            //1st Array length
            for (int k = 0; k < jaggedArray.Length; k++)
                //Length of each separate child Array - calling length property of 1st dimension
                for (int l = 0; l < jaggedArray[k].Length; l++)
                    Console.WriteLine("jaggedArray: " + jaggedArray[k][l]);
        }

        //Lecture 9 - Methods
        static string LectureNine(string first, string second) //=> first + second; 3rd ver
        {
            //1st ver
            //string concatenated = first + second;
            //return concatenated;

            //2nd ver
            //return first + second;

            //else & else-if not needed here 
            //- when return statement is run, execution of the method stops and it returns to the caller of the method
            //if else & else-if were used, the Method would do exactly the same thing
            if (first == "")
                return "error";
            if (second == "")
                return "error";
            return first + second;
        }

        //Method Overload - same name, but 3 args
        static string LectureNine(string first, string second, string third)
        {
            if (first == "")
                return "error";
            if (second == "")
                return "error";
            if (third == "")
                return "error";
            return first + second;
        }

        //Exercices
        public static void ExerciseOne()
        {
            //Simple calculator - adds two numbers given by User
            Console.WriteLine("Which numbers do you want to add?");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("x is: " + x);

            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("y is: " + y);

            double result = x + y;

            Console.WriteLine("x + y = " + result);
            Console.ReadLine();
        }

        public static void ExerciseTwo()
        {
            //Code which will determine the sign of a number
            Console.WriteLine("Write a number");
            double x = double.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Your number has a minus sign");
            }
            else if (x > 0)
            {
                Console.WriteLine("Your number has a plus sign");
            }
            else
            {
                Console.WriteLine("Your number is a zero");
            }

            Console.WriteLine("Welcome to Simple chatbot. Do you wany to chat?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Yes":
                case "yes":
                case "Y":
                case "y":
                    Console.WriteLine("Ah, so it is 'yes'!");
                    break;
                case "No":
                case "no":
                case "N":
                case "n":
                    Console.WriteLine("Oh, so bye!");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't know that expression");
                    break;
            }

            Console.ReadLine();
        }

        public static void ExerciseThree()
        {
            //Sum numbers from 0 to n (inclusively) - n is your made up number

            Console.WriteLine("Give me a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum: " + sum);
        }

        public static void ExerciseFour()
        {
            //2 Arrays - 1st filled up manually, 2nd by Collection Initializer
            int[] arrayManual = new int[3];

            arrayManual[0] = 0;
            arrayManual[1] = 1;
            arrayManual[2] = 2;

            for (int i = 0; i < arrayManual.Length; i++)
                Console.WriteLine("arrayManual: " + i);

            string[] arrayCollInit = { "a", "b", "c" };

            for (int i = 0; i < arrayCollInit.Length; i++)
                Console.WriteLine("arrayCollIntit: " + i);
        }

        public static void ExerciseFive()
        {
            //Arrays - 1st - 2D jagged, 2nd - 2D multidimensional; in both exact content
            int[][] arrayJagged = new int[2][];
            arrayJagged[0] = new int[] { 10, 20, 30 };
            arrayJagged[1] = new int[] { 40, 50, 60 };

            for (int i = 0; i < arrayJagged.Length; i++)
                for (int j = 0; j < arrayJagged[i].Length; j++)
                    Console.WriteLine("arrayJagged: " + arrayJagged[i][j]);

            int[,] arrayMulti = { { 10, 20, 30 }, { 40, 50, 60 } };

            for (int k = 0; k < arrayMulti.GetLength(0); k++)
                for (int l = 0; l < arrayMulti.GetLength(1); l++)
                    Console.WriteLine("arrayMulti: " + arrayMulti[k, l]);
        }

        static int ExerciseSix(int firstInt, int secondInt)
        {
            //Method to add two ints
            return firstInt + secondInt;
        }

        static int ExerciseSix(int firstInt, int secondInt, bool isAddition)
        {
            //Method to either add or substract two numbers
            if (isAddition)
                return firstInt + secondInt;

            return firstInt - secondInt;
        }
    }
}

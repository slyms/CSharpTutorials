using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//20. Arrays
namespace SandeepSoni___Demo
{
    public static class ArrayDemo
    {
        public static void ArrayMethod()
        {
            Console.WriteLine("Input n for arForN: ");
            int.TryParse(Console.ReadLine(), out int n);

            //Declaration
            int[] arForN;
            //arForN - local Variable of type int Array on Stack & Reference to Array of n ints on heap
            //new int[n] - Array
            //new int[n] - Array is dynamic = it's size can be a Variable which value will be calculated only at runtime
            arForN = new int[n];
            //Initialization
            //1 - within Declaration
            int[] arForBrackets = { 1, 2, 3, 4 };
            //2
            arForBrackets = new int[] { 10, 20, 30, 40 };
            //3
            arForBrackets[0] = 200;
            arForBrackets[1] = 400;
            arForBrackets[2] = 300;
            arForBrackets[3] = 100;

            //arForN.Length - length of Array
            for (int i = 0; i < arForN.Length; i++)
            {
                Console.WriteLine("arForN: " + arForN[i]);
            }

            //Copy data from Array
            //Generic code - copy in respect of shorter Array - set smaller size
            Array.Copy(arForN, arForBrackets, arForBrackets.Length < arForN.Length ? arForBrackets.Length : arForN.Length);

            Console.WriteLine("\nCopied arForN to arForBrackets :");
            for (int i = 0; i < arForBrackets.Length; i++)
            {
                Console.WriteLine("arForBrackets " + arForBrackets[i]);
            }

            //Sort
            Console.WriteLine("\nBefore sort: ");
            for (int i = 0; i < arForBrackets.Length; i++)
            {
                Console.WriteLine("arForBrackets: " + arForBrackets[i]);
            }
            Array.Sort(arForBrackets);
            Array.Reverse(arForBrackets);
            Console.WriteLine("\nAfter sort-reverse: ");
            for (int i = 0; i < arForBrackets.Length; i++)
            {
                Console.WriteLine("arForBrackets: " + arForBrackets[i]);
            }            

            //Read line of characters, convert it to Array
            Console.WriteLine("Enter a series of numbers");
            string str = Console.ReadLine();
            //String spli to construct an Array
            string[] arrayString = str.Split(' ');

            foreach (string s in arrayString)
            {
                Console.WriteLine(s);
            }

            //Variable to store sum of input
            int tmp = 0;
            foreach (string s in arrayString)
            {
                int a = int.Parse(s);
                tmp += a;                
            }
            //Show average of input, 1.0 * tmp = to have double
            Console.WriteLine("Average: " + 1.0 * tmp / arrayString.Length);
            Console.WriteLine("Sum: " + tmp);
        }

        public static void ArrayMethodMax()
        {
            Console.Write("Enter the number of values to be compared: ");

            int n;
            n = int.Parse(Console.ReadLine());

            //Array initialization
            int[] arInt = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + "th value: ");
                arInt[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arInt.Length; i++)
            {
                Console.WriteLine(arInt[i] + " ");
            }
            //Print max of all values
            int maxValue = arInt.Max();
            Console.WriteLine("maxValue: " + maxValue);
        }

        public static void ArrayMethodMulti()
        {
            int[,] arrayMulti = new int[2, 3];
            arrayMulti[0, 0] = 0000;
            arrayMulti[0, 1] = 0001;
            arrayMulti[0, 2] = 0002;
            arrayMulti[1, 0] = 1000;
            arrayMulti[1, 1] = 1001;
            arrayMulti[1, 2] = 2002;

            Console.WriteLine("arrayMulti:");
            Console.WriteLine(arrayMulti[0, 0] + " " + arrayMulti[0, 1] + " " + arrayMulti[0, 2]);
            Console.WriteLine(arrayMulti[1, 0] + " " + arrayMulti[1, 1] + " " + arrayMulti[1, 2]);

            int[,] arrayMultiBrackets = { { 0, 1, 2 }, { 1000, 1001, 2002 } };
            arrayMulti[0, 0] = 0000;
            arrayMulti[0, 1] = 0001;
            arrayMulti[0, 2] = 0002;
            arrayMulti[1, 0] = 1000;
            arrayMulti[1, 1] = 1001;
            arrayMulti[1, 2] = 2002;

            Console.WriteLine("arrayMultiBrackets:");
            Console.WriteLine(arrayMultiBrackets[0, 0] + " " + arrayMultiBrackets[0, 1] + " " + arrayMultiBrackets[0, 2]);
            Console.WriteLine(arrayMultiBrackets[1, 0] + " " + arrayMultiBrackets[1, 1] + " " + arrayMultiBrackets[1, 2]);
            Console.WriteLine("arrayMultiBrackets.Length: " + arrayMultiBrackets.Length);

            int[,,] arrayMultiThreeDim = new int [2, 3, 2] { { { 1, 1 }, { 1, 2 }, { 1, 3 } }, {{2, 1}, {2, 2}, {2, 3}} };
            Console.WriteLine("arrayMultiThreeDim.Rank - no of dimensions: " + arrayMultiThreeDim.Rank);
            Console.WriteLine(arrayMultiThreeDim.GetLength(0));
            Console.WriteLine(arrayMultiThreeDim.GetLength(1));
            Console.WriteLine(arrayMultiThreeDim.GetLength(2));
        }
    }
}

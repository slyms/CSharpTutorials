using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSetterFunFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic();
            Random();
            UsersInput();
        }

        public static void Basic()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void Random()
        {
            do
            {
                Random r = new Random();
                var bgColorValue = r.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), bgColorValue);
                Console.Clear();
                var fgColorValue = r.Next(0, 16);
                Console.ForegroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), fgColorValue);
                Console.WriteLine($"Background color: {Console.BackgroundColor.ToString()}, ForegroundColor: {Console.ForegroundColor.ToString()}");
            } while (Console.ReadKey().Key != ConsoleKey.E);
            Console.WriteLine();
            Console.WriteLine("Goodbye!");
        }

        public static void UsersInput()
        {
            string input = null;
            while (input != "e")
            {
                input = Console.ReadLine();
                var data = input.Split(' ');
                if (data.Length == 2)
                {
                    Int32.TryParse(data[0], out int bgColorValue);
                    Int32.TryParse(data[1], out int fgColorValue);
                    Console.BackgroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), bgColorValue);
                    Console.Clear();
                    Console.ForegroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), fgColorValue);
                    Console.WriteLine($"Background color: {Console.BackgroundColor.ToString()}, ForegroundColor: {Console.ForegroundColor.ToString()}");
                }
            };
            Console.WriteLine("Goodbye!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace AllenS_CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 34.1, 66.6 };
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello without args!");
            }

            var book = new Book("Sly's Grade Book");
            Console.WriteLine("Please insert grade(s):");

            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finally - clean things up");
                }
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"Grade Highest: {stats.High:N3} ");
            Console.WriteLine($"Grade Average: {stats.Average:N3} ");
            Console.WriteLine($"Grade Smallest: {stats.Low:N3} ");
            Console.WriteLine($"Grade Letter: {stats.Letter} ");

            //book.AddGrade(89.1);
            //book.AddGrade(90.5);
            //book.AddGrade(77.5);
        }
    }
}

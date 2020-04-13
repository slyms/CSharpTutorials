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

            IBook book = new DiskBook("Sly's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;

            Console.WriteLine("Please insert grade(s):");
            
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named '{book.Name}'");
            Console.WriteLine($"School '{InMemoryBook.school}'");
            //IBook - not implemented
            //Console.WriteLine($"Category '{book.CATEGORY}'");

            Console.WriteLine($"Grade Highest: {stats.High:N3} ");
            Console.WriteLine($"Grade Average: {stats.Average:N3} ");
            Console.WriteLine($"Grade Smallest: {stats.Low:N3} ");
            Console.WriteLine($"Grade Letter: {stats.Letter} ");

            //book.AddGrade(89.1);
            //book.AddGrade(90.5);
            //book.AddGrade(77.5);
        }

        //Extracted Method
        private static void EnterGrades(IBook book)
        {
            while (true)
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
        }

        // A static Method can reach only other static Members 
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade was added");
        }
    }
}

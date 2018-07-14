using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.BackgroundColor = ConsoleColor.White;
           // Console.WriteLine("Hello World");
           // Console.ReadLine();

            Person Sylwester = new Person();
            Sylwester.Name = "Sylwester";
            Sylwester.Age = 35;

            // Debugging through line of complex code
            int result = Sylwester.CalculateDogAge();
            Console.WriteLine(result);

            // Debugging through an If Statement
            bool olderThan18 = Sylwester.IsOlderThanOrEqualTo18();
            Console.WriteLine(olderThan18);

            // Debugging though a Loop
            Sylwester.PrintAsteriskEqualToAge();

            // Debugging with Call Stack
        }
    }
}

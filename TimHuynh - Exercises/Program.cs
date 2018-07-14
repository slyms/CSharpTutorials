using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Console.WriteLine("Current Project Dir: " + Environment.CurrentDirectory);
            Console.WriteLine("System Dir: " + Environment.SystemDirectory);
            Console.WriteLine("Computer Name: " + Environment.MachineName);
            Console.WriteLine("Current Day of the Week: " + DateTime.Now.DayOfWeek);
            Console.WriteLine("Time Zone: " + TimeZone.CurrentTimeZone.StandardName);
        }
    }
}

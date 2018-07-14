using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace of referenced Library
using TimHuynh_GreetingsAroundTheGlobe;

namespace TimHuynh
{
    class Program
    {
        //Console app - can accept an array of strring params
        static void Main(string[] args)
        {
            Console.WriteLine("Great things starts with the first step");

            while (true)
            {
                Console.WriteLine("Where do you come from?");
                string country = Console.ReadLine();

                //If User prints nothing or just hits Enter
                if (String.IsNullOrEmpty(country))
                {
                    Console.WriteLine("Bye for now!");
                    break;
                }
                //Call the Method in the Assembly
                Console.WriteLine(Greetings.SayHelloInLanguage(country));
            }
        }
    }
}

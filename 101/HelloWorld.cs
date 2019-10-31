using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    class HelloWorld
    {
        public void HelloWorldMethod()
        {
            Console.WriteLine("HelloWorldMethod");

            string firstFriend = "Bill";
            string secondFriend = "Maria";
            Console.WriteLine($"Hello World! Hello {firstFriend} and {secondFriend}");
            Console.WriteLine($"Hello World! Hello {firstFriend}. This name has {firstFriend.Length} letters");
            Console.WriteLine($"Hello World! Hello {secondFriend}. This name has {secondFriend.Length} letters");

            string greeting = "   Hello World!   ";
            string trimmedGreetingStart = greeting.TrimStart();
            string trimmedGreetingEnd = greeting.TrimEnd();

            Console.WriteLine($"[{trimmedGreetingStart}]");
            Console.WriteLine($"[{trimmedGreetingEnd}]");

            string replacedGreeting = greeting.Replace("Hello", "Greeting");
            Console.WriteLine($"{replacedGreeting}");

            string toUpper = greeting.ToUpper();
            string toLower = greeting.ToLower();
            Console.WriteLine($"{toUpper}");
            Console.WriteLine($"{toLower}");

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("bye"));
        }
    }
}

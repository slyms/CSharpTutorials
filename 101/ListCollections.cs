using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpGuide
{
    class ListCollections
    {
        public void ListCollectionsMethod()
        {
            var names = new List<string> { "Sly", "Ana", "Felipe" };
            
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            names.Sort();

            Console.WriteLine($"Added {names[2]} and {names[3]} to the list");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            Console.WriteLine();

            //Fibonacci numbers - calculate sum for 20 numbers - Ver 1.
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count() < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (int item in fibonacciNumbers)
                Console.WriteLine($"fibonacciNumbers: {item}");

            //Fibonacci numbers - calculate sum for 20 numbers - Ver 2. - mine
            int a = 1, b = 1;
            for (int i = 1; i <= 20; i++)
            {
                int result = a + b;
                a = b;
                b = result;
                Console.WriteLine($"fibonacciNumbers {i}: {result}");
            }
        }
    }
}

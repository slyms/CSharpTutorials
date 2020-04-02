using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    class BranchesAndLoops
    {
        public void BranchesAndLoopsMethod()
        {
            Console.WriteLine();
            Console.WriteLine("--- BranchesAndLoopsMethod ---");
            Console.WriteLine();

            Console.WriteLine("IF");
            int a = 5;
            int b = 3;
            int c = 4;
            bool condition = (a + b + c > 10) || (a == b);
            if (condition)
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And/Or the first number is equal to second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And/Or the first number is not equal to second");
            }

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And/Or the first number is not equal to second");
            }

            Console.WriteLine();

            Console.WriteLine("WHILE");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            Console.WriteLine();

            Console.WriteLine("DO WHILE");
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            while (counter < 10);

            Console.WriteLine();

            Console.WriteLine("FOR");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"hello World! The index i {index}");
            }

            Console.WriteLine();

            Console.WriteLine("Exercise");

            int sum = 0;
            for (int number = 1; number <= 20; number++)
            {
                if ((number % 3) == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"Sum of all integers 1 through 20 that are divisible by 3: {sum}");
            Console.WriteLine();
        }
    }
}

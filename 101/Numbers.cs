using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    class Numbers
    {
        public void NumbersMethod()
        {
            Console.WriteLine("NumbersMethod");
            int a = 18;
            int b = 6;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine($"d = a + b * c: {d}");

            d = (a + b) * c;
            Console.WriteLine($"d = (a + b) * c: {d}");

            d = (a + b) * c / 9;
            Console.WriteLine($"d = (a + b) * c / 9: {d}");
            d = (a + b) * c % 9;
            Console.WriteLine($"d = (a + b) * c % 9: {d}");

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine($"The range of int is {minInt} to {maxInt}");

            int underflow = minInt - 1;
            Console.WriteLine($"Underflow: {underflow}");

            double g = 5;
            double e = g / 9;
            Console.WriteLine($"e = (a + b) * c / 9: {e}");

            double maxD = double.MaxValue;
            double minD = double.MinValue;
            Console.WriteLine($"The range of double is {minD} to {maxD}");

            double roundingDoub = 1.0 / 3.0;
            Console.WriteLine($"roundingDoub: {roundingDoub}");

            decimal f = (a + b) * c / 9;
            Console.WriteLine($"f = (a + b) * c / 9: {f}");

            decimal maxDec = decimal.MaxValue;
            decimal minDec = decimal.MinValue;
            Console.WriteLine($"The range of decimal is {minDec} to {maxDec}");

            decimal roundingDec = 1.0M / 3.0M;
            Console.WriteLine($"roundingDec: {roundingDec}");

            double radius = 2.50;
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"Area of circle = {circleArea}");
        }
    }
}

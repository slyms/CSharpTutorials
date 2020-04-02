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
            Console.WriteLine();
            Console.WriteLine("--- NumbersMethod ---");
            Console.WriteLine();
            int a = 18;
            int b = 6;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine("INTEGER");
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

            int what = maxInt + 3;
            Console.WriteLine($"Overflow: maxInt + 3 = {what}");

            int underflow = minInt - 1;
            Console.WriteLine($"Underflow: minInt - 1 = {underflow}");

            Console.WriteLine();
            Console.WriteLine("DOUBLE");
            double g = 5;
            double e = g / 9;
            Console.WriteLine($"e = (a + b) * c / 9: {e}");

            double maxD = double.MaxValue;
            double minD = double.MinValue;
            Console.WriteLine($"The range of double is {minD} to {maxD}");

            double roundingDoub = 1.0 / 3.0;
            Console.WriteLine($"roundingDoub: 1.0 / 3.0 = {roundingDoub}");

            Console.WriteLine();
            Console.WriteLine("DECIMAL");
            decimal f = (a + b) * c / 9;
            Console.WriteLine($"f = (a + b) * c / 9: {f}");

            decimal maxDec = decimal.MaxValue;
            decimal minDec = decimal.MinValue;
            Console.WriteLine($"The range of decimal is {minDec} to {maxDec}");

            decimal roundingDec = 1.0M / 3.0M;
            Console.WriteLine($"roundingDec: 1.0M / 3.0M = {roundingDec}");

            Console.WriteLine();
            Console.WriteLine("LONG");

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine($"The range of long is {minLong} to {maxLong}");

            Console.WriteLine();
            Console.WriteLine("SHORT");

            long maxShort = long.MaxValue;
            long minShort = long.MinValue;
            Console.WriteLine($"The range of short is {minShort} to {maxShort}");

            Console.WriteLine();
            Console.WriteLine("MATH");
            double radius = 2.50;
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"Area of circle = {circleArea}");
        }
    }
}

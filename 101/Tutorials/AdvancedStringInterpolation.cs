using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide.Tutorials
{
    public class AdvancedStringInterpolation
    {
        public void AdvancedStringInterpolationMethod()
        {
            double a = 3;
            double b = 4;

            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            Console.WriteLine($"Length of the hypotenuse of the right traingle with legs of {a} and {b} is { CalculateHypotenuse(a, b)}");

            double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

            Console.WriteLine();

            //Format string
            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to " +
                $"Christian Goldbach");

            Console.WriteLine();

            //Field width && alignment
            const int NameAlignment = -9;
            const int ValueAlignment = 7;

            double c = 3;
            double d = 4;

            Console.WriteLine($"Three classical Pythagorean means of {c} and {d}:");
            Console.WriteLine($"|{"Arithmentic", NameAlignment}|{0.5 * (a + b), ValueAlignment:F3}|");
            Console.WriteLine($"|{"Geometric", NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
            Console.WriteLine($"|{"Harmonic", NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");

            Console.WriteLine();

            //Escape sequences
            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);

            //Ternary operator
            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
            }

            Console.WriteLine();

            //Culture-specific result string
            var cultures = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
                System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
                System.Globalization.CultureInfo.InvariantCulture
            };

            var dateNow = DateTime.Now;
            var number = 31_415_926.536;
            FormattableString message = $"{dateNow, 20}{number, 20:N3}";
            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name, -10}{cultureSpecificMessage}");
            }

            Console.WriteLine();

            //Invariant culture result string
            string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
            Console.WriteLine(messageInInvariantCulture);
        }
    }
}

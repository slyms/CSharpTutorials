using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllenS_CSharpProgrammingParadigms
{
    public class Linq
    {
        public void Cities()
        {
            IEnumerable<string> cities = new[] { "Ghent", "Lodon", "Las Vegas", "Hyderabad" };

            foreach (var city in cities)
            {
                Console.WriteLine($"City: {city}");
            }
        }    

        public void DateExtension()
        {
            DateTime date = new DateTime(2002, 8, 9);

            int daysTillEndOfMonth = DateUtilities.DaysToEndOfMonth(date);

            Console.WriteLine(daysTillEndOfMonth);
        }
    }

    public static class DateUtilities
    {
        public static int DaysToEndOfMonth(DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
    }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<string> StringsThatStartWith(IEnumerable<string> input, string start)
        {
            foreach(var s in input)
            {
                if (s.StartsWith(start))
                {
                    yield return s;
                }
            }
        }
    }
}

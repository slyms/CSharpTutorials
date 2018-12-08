using System;

    class Program
    {
        enum Colors
        {
            white, black, red
        }

        public static void Main(string[] args)
        {
            Colors newColor = Colors.white;

            string stringColor = newColor.ToString();

            string stringValue = "red";
            Colors colorsValue = (Colors)Enum.Parse(typeof(Colors), stringValue);

            Console.WriteLine(newColor + " " + stringColor + " " + stringValue + " " + colorsValue);
        }
    }

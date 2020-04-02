using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide.Tutorials
{
    public class ProgramTutorials
    {
        public static void Main()
        {
            Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);

            CSharp6 bu = new CSharp6();
            bu.CSharp6Method();

            StringInterpolation stringInterpolation = new StringInterpolation();
            stringInterpolation.StringInterPolationMethod();

            Vegetable vegetable = new Vegetable("rose");
            vegetable.VegetableMethod();

            Example example = new Example();
            example.ExampleMethod();

            AdvancedStringInterpolation advancedStringInterpolation = new AdvancedStringInterpolation();
            advancedStringInterpolation.AdvancedStringInterpolationMethod();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide.Tutorials
{
    public class StringInterpolation
    {
        public void StringInterPolationMethod()
        {
            var name = "Sylwester";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }
    }

    public class Vegetable
    {
        //Constructor
        public Vegetable(string name) => Name = name;

        //Property
        public string Name { get; }

        public override string ToString() => Name;

        public enum Unit { item, kilogram, gram, dozen };

        public void VegetableMethod()
        {
            //Instance of Vegetable Class
            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;

            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}");
            Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}");
            Console.WriteLine($"On {date:t}, the price of {item} was {price:e} per {unit}");
            Console.WriteLine($"On {date:y}, the price of {item} was {price} per {unit}");
            Console.WriteLine($"On {date:yyyy}, the price of {item} was {price:F3} per {unit}");
        }
    }

    public class Example
    {
        public void ExampleMethod()
        {
            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Artur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };

            Console.WriteLine($"[{DateTime.Now, -20:d}] Hour [{DateTime.Now, -10:HH}] [{1063.342, 15:N2}] feet");
            Console.WriteLine();
            Console.WriteLine("Author and Title List");
            Console.WriteLine($"|{"Author", -25}|{"Title", 30}|");
            foreach (var title in titles)
                Console.WriteLine($"|{title.Key, -25}|{title.Value, 30}|");
        }
    }
}

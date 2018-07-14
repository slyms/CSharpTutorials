using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh_GreetingsAroundTheGlobe
{
    public class Greetings
    {
        internal static Dictionary<string, string> HelloLookup { get; private set; }

        public static string SayHelloInLanguage(string country)
        {
            //Instantiate the dictionary lookup of country and language
            HelloLookup = new Dictionary<string, string>()
            {
                //key - value
                {"america", "Hello!" },
                {"australia", "Good day mate!" },
                {"england", "Hello!" },
                {"france", "Bonjour!" },
                {"spain", "Hola!" },
                {"italy", "Ciao!" },
                {"india", "Namaste!" },
                {"japan", "Ohayo!" },
                {"korea", "Ahn-Young-Ha-Se-Yo!" },
                {"indonesia", "Ohayo!" },
                {"china", "Halo!" },
                {"vietnam", "Ni Hau!" },
                {"poland", "Cześć!" },
            };

            //User input - convert to lower case
            string lowercaseCountry = country.ToLower();
            //User input - pass to TryGetValue as key
            //If for given key value is found - return greeting
            //If not - return string
            if (HelloLookup.TryGetValue(lowercaseCountry, out string greeting))
            {
                return greeting;
            }
            return "We're not sure hot to say hi in your language. Let's just say Hello! :)";
        }
    }
}

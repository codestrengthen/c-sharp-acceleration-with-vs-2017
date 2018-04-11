using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsAroundTheGlobe
{
    public class Greetings
    {
        internal static Dictionary<string, string> HelloLookup { get; private set; }
        
        public static string SayHelloInLanguage(string country)
        {
            //Instantiate the dictionary lookup of country and language
            HelloLookup = new Dictionary<string, string>()
            {
                { "america", "Hello!" },
                { "australia", "Good day mate!" },
                { "england", "Hello!" },
                { "france", "Bonjour!" },
                { "spain", "Hola!" },
                { "italy", "Ciao!" },
                { "india", "Namaste" },
                { "japan", "Ohayo!" },
                { "korea", "Ahn-Young-Ha-Se-Yo!" },
                { "indonesia", "Halo!"},
                { "china", "Ni Hau!"},
                { "vietnam", "Xin chao!"}
            };

            string lowercaseCountry = country.ToLower();
            if (HelloLookup.TryGetValue(lowercaseCountry, out string greeting))
            {
                return greeting;
            }
            return "We're not sure how to say hi in your language... Let's just say Hello! :)";
        }
    }
}

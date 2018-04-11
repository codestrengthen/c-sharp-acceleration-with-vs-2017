using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetingsAroundTheGlobe;

namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Where do you come from?");
                string country = Console.ReadLine();
                if (String.IsNullOrEmpty(country))
                {
                    Console.WriteLine("Bye for now!");
                    break;
                }
                //call the method in the assembly
                Console.WriteLine(Greetings.SayHelloInLanguage(country));
            }
        }
    }
}

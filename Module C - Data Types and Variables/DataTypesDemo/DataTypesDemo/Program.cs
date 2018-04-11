using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'X';        // Character literal
            char ch2 = '\x0058';   // Hexadecimal
            char ch3 = (char)88;   // Cast from integral type
            char ch4 = '\u0058';   // Unicode

            int int1 = ch3;        //Cast to integral type

            //use the "int" alias to declare a variable
            int intVal = 8;

            //use the struct "System.Int32" to call the built-in method to convert the string "8" to integer
            int parsedIntVal = System.Int32.Parse("8");

            //assign value to the "global variable"
            Student.TopStudentName = "Andrew";
        }

        enum AustralianStates
        {   
            NewSouthWales,  // integer value = 0 unless set
            NorthernTerritory = 2, //manually change the integer value of a named constant
            Queensland,
            SouthAustralia,
            Tasmania,
            Victoria,
        }

        public struct MapCoordinate
        {
            public double x;
            public double y;
        }

        public double? GPA { get; set; }

        public string GetStudentName()
        {
            string name = "John"; //"name" is a local variable
            return name;
        }
    }
}

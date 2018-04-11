using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class Student
    {
        //use "static" to declare this property belongs to the Student type.
        //This effectively makes it become a "global variable" because it can be accessed anywhere in the code, 
        //not limited inside a method
        public static string TopStudentName { get; set; }

    }
}

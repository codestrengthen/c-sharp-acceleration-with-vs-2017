using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    class OperatorsDemo
    {
        public void PrefixIncrement()
        {
            var x = 0;
            while (x < 5)
            {
                Console.WriteLine(++x);
            }
            //Output will be: 
            //1
            //2
            //3
            //4
            //5
        }

        public void PostfixIncrement()
        {
            var x = 0;
            while (x < 5)
            {
                Console.WriteLine(x++);
            }
            //Output will be: 
            //0
            //1
            //2
            //3
            //4
        }

        public void TypeCasting()
        {
            double d = 8;
            int i = (int)d; //cast double variable to integer type
        }

        public void EqualityOperator()
        {
            var movie1 = new Movie();
            var x = movie1;
            var y = movie1;
            // (x == y) check will return true
        }

        public string ConditionalOperator()
        {
            var age = 18;
            var x = age < 18 ? "Cannot buy alcohol" : "Eligible to buy alcohol";
            return age < 18 ? "Cannot buy alcohol" : "Eligible to buy alcohol";
            //if age is less than 18, return "Cannot buy alcohol";
            //otherwise, return "Eligible to buy alcohol"
        }
    }
}

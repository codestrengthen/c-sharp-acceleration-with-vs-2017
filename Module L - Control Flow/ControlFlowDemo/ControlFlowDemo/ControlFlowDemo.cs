using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDemo
{
    class ControlFlowDemo
    {
        public void IfElse()
        {
            int mark = 88;
            if(mark >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            if(mark >= 50 && mark <= 59)
            {
                Console.WriteLine("Pass");
            }
            else if(mark >= 60 &&  mark <= 69)
            {
                Console.WriteLine("Credit");
            }
            else if (mark >= 70 && mark <= 79)
            {
                Console.WriteLine("Distinction");
            }
            else if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("High Distinction");
            }

            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("High Distinction");
                if (mark >= 95)
                {
                    Console.WriteLine("Top class!");
                }
            }

            ////Conditional Operator examples:

            //string examResult = mark >= 50 ? "Pass": "Fail";
            string examResult = mark >= 50 && mark <= 59 ? "Pass" :
                                mark >= 60 && mark <= 69 ? "Credit" : "Continue to chain the operator...";
        }

        public void For()
        {
            for(var i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            /*
            Output:
            1
            2
            3
            4
            5
            */
        }

        public void ForEach()
        {
            string[] myFavoriteDishes = new string[] { "Ceasar Salad", "Vietnamese Beef Noodle", "Sushi", "KFC" };
            foreach (string d in myFavoriteDishes)
            {
                Console.WriteLine(d);
            }
            /*
             Output:
                Ceasar Salad
                Vietnamese Beef Noodle
                Sushi
                KFC
             */

            //List<string> sourceCollection = new List<string>();
            //foreach(string elem in sourceCollection)
            //{
            //    //Do not add or remove element of the source collection in the foreach loop. Things may get out of control...
            //    sourceCollection.Add("new item");
            //    sourceCollection.Remove("existing item");
            //}
        }

        public void WhileAndDoWhile()
        {
            //while example
            int i = 1;
            while (i <= 5)
            {
                //Loop will run infinitely (displays "1"s on the console window) because i is not incremented
                Console.WriteLine(i);
            }

            //do-while example
            int o = 1;
            do
            {
                Console.WriteLine(o);
                o++;
            } while (o <= 5);
        }

        //Football = 0, Golf = 1, Rugby = 2, Soccer = 3, Tennis = 4
        private enum Sport { Football, Golf, Rugby, Soccer, Tennis }

        public void Switch()
        {
            //Generate a random number between 0 to 5. 
            //We don't specify a route for "5", so control will jump into the default route
            Sport s = (Sport)(new Random()).Next(0, 6);
            switch (s)
            {
                case Sport.Football:
                    Console.WriteLine("You are no-nonsense and know exactly what you want to do.");
                    break;
                case Sport.Golf:
                    Console.WriteLine("You are very smart and there is always a reason behind everything you do.");
                    break;
                case Sport.Rugby:
                    Console.WriteLine("You are incredibly strong, both mentally and physically.");
                    break;
                case Sport.Soccer:
                    Console.WriteLine("You are disciplined and have unparalleled organization skills.");
                    break;
                case Sport.Tennis:
                    Console.WriteLine("You are a bit aggressive and vastly independent.");
                    break;
                default:
                    Console.WriteLine("Even without a favourite sport, you are still a decent human being. :)");
                    break;
            }
        }

        public void Break()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Statement follows the terminated loop.");
            /* 
             Output:
                1
                2
                3
                4  
                Statement follows the terminated loop.
            */
        }

        public void Continue()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Statement follows the loop.");
            /* 
             Output:
                1
                2
                3
                4
                6
                ...
                99
                100
                Statement follows the loop.
            */
        }

        public void Return()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    return;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Statement follows the terminated loop.");
            /* 
             Output:
                1
                2
                3
                4
            */
        }

        public void GoTo()
        {
            Sport s = (Sport)(new Random()).Next(0, 6);
            switch (s)
            {
                case Sport.Football:
                    Console.WriteLine("You are no-nonsense and know exactly what you want to do.");
                    goto case Sport.Soccer; //control jumps into case Sport.Soccer
                case Sport.Golf:
                    Console.WriteLine("You are very smart and there is always a reason behind everything you do.");
                    break;
                case Sport.Rugby:
                    Console.WriteLine("You are incredibly strong, both mentally and physically.");
                    break;
                case Sport.Soccer:
                    Console.WriteLine("You are disciplined and have unparalleled organization skills.");
                    break;
                case Sport.Tennis:
                    Console.WriteLine("You are a bit aggressive and vastly independent.");
                    break;
                default:
                    Console.WriteLine("Even without a favourite sport, you are still a decent human being. :)");
                    break;
            }
        }
    }
}

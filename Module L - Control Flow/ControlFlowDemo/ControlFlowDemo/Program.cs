using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlFlowDemo c = new ControlFlowDemo();
            c.IfElse();

            ////The while loop is used to accept user's input and generates a random number from 0 to 5 each time. 
            ////It is used to demonstrate the Switch and GoTo's examples.
            ////Type in anything to generate a random result. Simply press "Enter" to terminate the program.

            //while (Console.ReadLine() != "")
            //{
            //    c.Switch();
            //}
        }
    }
}

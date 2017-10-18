using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            
            while (index < 10) //boolean expression expected
            {
                //This will be executed as long the above condition is true.
                Console.WriteLine("The number is {0}", index);
                index = index + 1;
            }

            string input = Console.ReadLine();

            /*while only executes only if condition is true. 
            If first time, the condition is false, the code block never runs.*/
            while (!input.Equals(string.Empty))
            {
                Console.WriteLine("Your input is {0}", input);
                input = Console.ReadLine();
            }

        }
    }
}

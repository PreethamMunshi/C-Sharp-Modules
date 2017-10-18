using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string input2 = string.Empty;
            do
            {
                //this block will always run even though the condition below is false. At least first execution is guaranteed.
                input2 = Console.ReadLine();
                Console.WriteLine("Your Input is {0}", input2);

            }
            while (!input2.Equals(string.Empty));
        }
    }
}

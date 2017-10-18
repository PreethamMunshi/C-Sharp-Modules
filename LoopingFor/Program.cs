using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingFor
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(initializer, condition , iterator)
            for (int i = 0; i < 10; i++)
            {
                if ( i == 1) continue;
                Console.WriteLine("The i is {0}", i);
            }
        }
    }
}

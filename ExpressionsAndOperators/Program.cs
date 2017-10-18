using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int simpleExpression1 = 5 - 10;
            int simpleExpression2 = 8 * 2;
            int complexExpression = (((6 * 7) + 5) + simpleExpression1) / simpleExpression2;

            Console.WriteLine(simpleExpression1);
            Console.WriteLine(simpleExpression2);
            Console.WriteLine(complexExpression);

            Console.ReadLine();
        }
    }
}

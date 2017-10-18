using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountofBooks = 1;
            string myName = "Preetham";
            bool isCompatible = true;
            string number = "2";
            int numberConverted = Convert.ToInt32(number);

            Console.WriteLine(CountofBooks);
            Console.WriteLine(myName);
            Console.WriteLine(isCompatible);
            Console.WriteLine(number);
            Console.WriteLine(numberConverted);

            Console.ReadLine();
        }
    }
}

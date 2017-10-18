using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Preetham":
                    Console.WriteLine("This is me");
                    break;
                case "VS":
                    Console.WriteLine("This is my IDE");
                    break;
                default:
                    Console.WriteLine("No case match");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice1 = Console.ReadLine();
            string choice2 = Console.ReadLine();

            //it is difficult to implement switch statements with multiple variables.
            switch (choice1)
            {
                case "Preetham":
                    Console.WriteLine("This is my name");
                    break;
                case "Visual Studio":
                    Console.WriteLine("This is my IDE");
                    break;
                default:
                    Console.WriteLine("This is neither me nor my IDE");
                    break;
            }

            if (choice1.Equals("Preetham") && choice2.Equals("Munshi"))
            {
                Console.WriteLine("This is my name");
            }
            else if (choice1.Equals("Visual Studio"))
            {
                Console.WriteLine("This is my IDE");
            }
            else
            {
                Console.WriteLine("This is neither me nor my IDE");
            }
        }
    }
}

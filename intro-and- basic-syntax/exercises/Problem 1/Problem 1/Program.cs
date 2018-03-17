using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiving four lines of integers which are interpreted as debit card numbers
            int numberOne = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            //Printing those four lines of integers to a debit card-like pattern
            Console.Write($"{num1:d4} ");
            Console.Write($"{num2:d4} ");
            Console.Write($"{num3:d4} ");
            Console.Write($"{num4:d4} ");
//changed variable name from num1 to numberOne.
        }
    }
}

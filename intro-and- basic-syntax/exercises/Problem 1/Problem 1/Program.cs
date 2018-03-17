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
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.Write($"{num1:d4} ");
            Console.Write($"{num2:d4} ");
            Console.Write($"{num3:d4} ");
            Console.Write($"{num4:d4} ");
        }
    }
}

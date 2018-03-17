//Confirmed from delyandamyanov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we declare how many miles we want to convert to kilometers 
            double a = double.Parse(Console.ReadLine());
            //Here is the constant we use in the convertion formula
            double b = 1.60934;
            //Here we convert the miles into kilometers and receive the answer in the console window
            Console.WriteLine($"{a * b:f2}");

        }
    }
}
//CONFIRMED from Evelin Turiyski.
using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// In the next two lines we receive
			// the width and the height as a double floating point.
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
			// We calculate the result by the given formula.
            double result = width * height;
			
			// We print the result.
            Console.WriteLine($"{result:F2}");
        }
    }
}

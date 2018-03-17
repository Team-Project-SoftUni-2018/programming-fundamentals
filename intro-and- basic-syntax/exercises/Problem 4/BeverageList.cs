//Confirmed from delyandamyanov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the name.
            string name = Console.ReadLine();
            //Read the volume.
            int vol = int.Parse(Console.ReadLine());
            //Read the energy.
            int energy = int.Parse(Console.ReadLine());
            //Read the sugar. 
            int sugar = int.Parse(Console.ReadLine());

            //Print the solution.
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", vol, name, ((energy * vol)/100.0), ((sugar * vol)/100.0));
        }
    }
}

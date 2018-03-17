using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Name: {0}\nHealth: |{1}|\nEnergy: |{2}|", 
                name, new String('|', currHealth) + new string('.', maxHealth - currHealth), 
                new String('|', currEnergy) + new string('.', maxEnergy - currEnergy));
        }

    }
    
}

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
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Name: {0}\nHealth: |{1}|\nEnergy: |{2}|", 
                name, new String('|', currentHealth) + new string('.', maximumHealth - currentHealth), 
                new String('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy));
        }

    }
    
}

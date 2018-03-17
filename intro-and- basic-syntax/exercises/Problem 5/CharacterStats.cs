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
            //We receive character name
            String name = Console.ReadLine();
            //Character health
            int currentHealth = int.Parse(Console.ReadLine());
            //Maximum Character Health
            int maximumHealth = int.Parse(Console.ReadLine());
            //Current Character Energy
            int currentEnergy = int.Parse(Console.ReadLine());
            //Maximum Character Energy
            int maximumEnergy = int.Parse(Console.ReadLine());
            
            //Printing information about the character
            Console.WriteLine("Name: {0}\nHealth: |{1}|\nEnergy: |{2}|", 
                name, new String('|', currentHealth) + new string('.', maximumHealth - currentHealth), 
                new String('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy));
        }

    }
    
}

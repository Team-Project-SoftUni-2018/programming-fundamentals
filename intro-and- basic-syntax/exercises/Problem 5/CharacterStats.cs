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
            int currHealth = int.Parse(Console.ReadLine());
            //Maximum Character Health
            int maxHealth = int.Parse(Console.ReadLine());
            //Current Character Energy
            int currEnergy = int.Parse(Console.ReadLine());
            //Maximum Character Energy
            int maxEnergy = int.Parse(Console.ReadLine());
            
            //Printing information about the character
            Console.WriteLine("Name: {0}\nHealth: |{1}|\nEnergy: |{2}|", 
                name, new String('|', currHealth) + new string('.', maxHealth - currHealth), 
                new String('|', currEnergy) + new string('.', maxEnergy - currEnergy));
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    static class MonsterManager //
    {
        static List<Monster> Monsters;

        public static Monster ChooseMonster(string input)
        {
            for (int i = 0; i < Monsters.Count; i++)
            {
                if (input == Monsters[i].Name)
                {
                    return Monsters[i];
                }
            }

            return null; //Get error message
        }

        public Monster Breed(Monster male, Monster female)
        {
            Offspring child = new Offspring();

            for (int i = 0; i < male.Genes.Length; i++)
            {
                int chanse = generator.Next(1); //Lägg generator i main. Kalla på den genom Program.Generator

                if (generator.Next(1) == 0)
                {
                    child.Genes[i] = male.Genes[i];
                }

                else
                {
                    child.Genes[i] = female.Genes[i];
                }
            }

            return child;
        }
    }
}

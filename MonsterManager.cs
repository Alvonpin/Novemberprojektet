using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    static class MonsterManager 
    {
        public static List<Monster> Monsters = new List<Monster>();

        public static void CreateMonster(Monster monster)
        {
            Monsters.Add(monster);
        }

        public static void CreateAncestors()
        {
            CreateMonster(new Ancestor("Adam", Monster.Genders.male));
            CreateMonster(new Ancestor("Eve", Monster.Genders.female));
            CreateMonster(new Ancestor("Samuel", Monster.Genders.male));
            CreateMonster(new Ancestor("Lilith", Monster.Genders.female));
        }

        public static void PrintMonsters()
        {
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].PrintName();
            }
        }

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

        public static Monster Breed(Monster male, Monster female)
        {
            Offspring child = new Offspring();

            for (int i = 0; i < male.Genes.Length; i++)
            {
                int chanse = Program.Generator.Next(1); //Lägg generator i main. Kalla på den genom Program.Generator

                if (Program.Generator.Next(2) == 0)
                {
                    child.Genes[i] = male.Genes[i];
                }

                else
                {
                    child.Genes[i] = female.Genes[i];
                }
            }

            child.GetTraits(); //Hämtar traits utifrån genes

            return child;
        }
    }
}

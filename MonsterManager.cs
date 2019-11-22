using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    //MonsterManager sköter hanteringen av monster, således även ancestors och offpring som är en typ av monster

    static class MonsterManager 
    {
        public static List<Monster> Monsters = new List<Monster>(); //Listan inehåller spelets monster

        public static void AddMonster(Monster monster)
        {
            Monsters.Add(monster);
        }

        //Skapar de monster som användaren börjar spelet med
        public static void CreateAncestors()
        {
            AddMonster(new Ancestor("Adam", Monster.Genders.male));
            AddMonster(new Ancestor("Eve", Monster.Genders.female));
            AddMonster(new Ancestor("Samuel", Monster.Genders.male));
            AddMonster(new Ancestor("Lilith", Monster.Genders.female));
        }

        public static void PrintMonsters()
        {
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].PrintName();
            }

            Console.WriteLine();
        }

        //Låter användaren välja ett befintligt monster ut listan av monster

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

        public static void RemoveMonster(Monster monster)
        {
            Monsters.Remove(monster);
        }


        /*Låter användaren välja två monster utifrån vilka ett nytt monster skapas med metoden GetOffspring.
         * Valda monster måsta vara av olika kön */
         
        public static void Breed (Monster monster)
        {
            if (monster.Genes[0] == 0)
            {
                TextManager.PrintInstruction("SelectFemale");
            }
            else
            {
                TextManager.PrintInstruction("SelectMale");
            }

            Monster partner = ChooseMonster(Console.ReadLine());

            if(partner.Genes[0] != monster.Genes[0])
            {
                Offspring child = GetOffspring(monster, partner);

                AddMonster(child);

                RevealOffspring(child);
            }

            else
            {
                TextManager.PrintInstruction("Error1");
                Console.ReadLine();
            }
        }


        //Ett nytt monster med nya egenskaper skapas utifrån två valda monsters gener

        public static Offspring GetOffspring(Monster male, Monster female)
        {
            Offspring child = new Offspring();

            for (int i = 0; i < male.Genes.Length; i++)
            {
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

        //Skiver ut resultatet av Breed-metoden samt låter användaren namnge det nya monstret

        public static void RevealOffspring(Offspring child)
        {
            TextManager.Clear("All");
            child.PrintTraits();
            Console.WriteLine();
            TextManager.PrintInstruction("Name");
            child.SetName(Console.ReadLine());
            
        }

        /*Hanterar användarens valmöjligheter då hen har valt ett monster och utför det valda alternativet
         *Om användaren väljer ett icke valbart alternativ får hen ett felmeddelande
         */

        public static void HandleMonsters(string input, Monster selectedMonster)
        {
            if (input == "a")
            {
                Breed(selectedMonster);

            }

            else if (input == "b")
            {
                TextManager.Clear("All");
                selectedMonster.PrintTraits();
                Console.ReadLine();
            }

            else if (input == "c")
            {
                Monsters.Remove(selectedMonster);
            }

            else
            {
                TextManager.PrintInstruction("Error2");
            }
        }

    }
}

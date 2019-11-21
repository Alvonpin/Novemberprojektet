using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Program
    {

        static List<Monster> Monsters;

        static void Main(string[] args)
        {
            Monsters = new List<Monster>();

            Monsters.AddRange(new Ancestor[]
            { new Ancestor("Adam", Monster.Genders.male),
              new Ancestor("Eve", Monster.Genders.female),
              new Ancestor("Samuel", Monster.Genders.male),
              new Ancestor("Lilith", Monster.Genders.female)});



            Console.WriteLine("Select a two monsters. Type the female monsters name, blanskspace, the male monsters name.");

            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].PrintName();
            }

            //Monster.Breed();
            Console.ReadLine();



        }
    }
}

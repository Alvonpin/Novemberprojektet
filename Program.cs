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

            Monsters.Add(new Monster(Monster.Genders.male));
            Monsters.Add(new Monster(Monster.Genders.female));




        }
    }
}

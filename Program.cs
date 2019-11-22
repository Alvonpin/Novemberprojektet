using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Program
    {
        public static Random Generator = new Random(); //Används av alla andra klasser

        static void Main(string[] args)
        {
            MonsterManager.CreateAncestors();

            while (true)
            {
                TextManager.PrintInstruction("Introduction");

                MonsterManager.PrintMonsters();

                Monster selectedMonster = MonsterManager.ChooseMonster(Console.ReadLine());

                TextManager.PrintInstruction("Actions");
                TextManager.PrintChoises();


                MonsterManager.HandleMonsters(Console.ReadLine(), selectedMonster);//Hanterar monster beroende på användarens val

                TextManager.Clear("All");
            }

        }
    }
}

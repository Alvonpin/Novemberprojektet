using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Program
    {
        public static Random Generator = new Random();

        static void Main(string[] args)
        {

            MonsterManager.CreateAncestors();

            Console.WriteLine("Select a male");
            Monster male = MonsterManager.ChooseMonster(Console.ReadLine());

            male.PrintAttributes();

            Console.WriteLine("Select a female");
            Monster female = MonsterManager.ChooseMonster(Console.ReadLine());

            female.PrintAttributes();

            Monster child = MonsterManager.Breed(male, female);

            child.PrintAttributes();

            Console.ReadLine();



        }
    }
}

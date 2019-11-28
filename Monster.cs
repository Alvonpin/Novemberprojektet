using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    /*Monster beskriver spelets monster och deras egenskaper
     *Klassen är abstrakt, detta innebär att den inte skapar instanser av sig själv, men kan ärvas av.
     *Ancestor och offspring ärver av monster då de delar vissa egenskaper, men är olika i andra avseenden.*/

    abstract class Monster 
    { 
        /*Enums tillåter en namn, i detta fall en egenskap, korrespondera till ett värde. 
         *På detta vis kan olika egenskaper hos ett monster korrespondera till värdena på dess genetiska uppsättning */

        public enum Genders { male,female }; //Exempel: male har index 0, female har index 1
        public enum Types { bird,reptile,mammal };
        public enum Colors { red,blue,yellow };
        public enum Patterns { striped,pied,none };

        protected int _id;
        protected string _name;
        protected Genders _gender;//Exempel: När ett male monster skapas kan _gender hämtas som både "male" och 0
        protected Types _type;
        protected Colors _color;
        protected Patterns _pattern;

        protected int[] _genes;

        /* Property som tillåter att ett monsters namn eller gener kan hämtas men inte ändras utifrån, 
         * detta för att kunna skriva ut monsters namn eller gener i metoder utanför klassen
         */

        public string Name 
        {
            get { return _name; }

        }

        public int[] Genes
        {
            get { return _genes; }

        }

        public void PrintName()
        {
            Console.WriteLine(_name);
        }

        public void PrintTraits()
        {
            Console.WriteLine(_name);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gender: " + _gender);
            Console.WriteLine("Type: " + _type);
            Console.WriteLine("Color: " + _color);
            Console.WriteLine("Pattern: " + _pattern);
            Console.WriteLine();
        }
    }
}

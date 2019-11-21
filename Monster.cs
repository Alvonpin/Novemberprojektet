using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    abstract class Monster  //En abstrakt klass kan inte skapa konstruktorer själv, men kan ärvas av
    { 
        public enum Genders { male,female };
        public enum Types { bird,reptile,mammal };
        public enum Colors { red,blue,yellow };
        public enum Patterns { striped,pied,none };

        protected int _id;
        protected string _name;
        protected Genders _gender;
        protected Types _type;
        protected Colors _color;
        protected Patterns _pattern;

        protected int[] _genes;

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public int[] Genes //Värdet av genes kan hämtas utifrån
        {
            get { return _genes; }

        }

        public void PrintName()
        {
            Console.WriteLine(_name);
        }

        public void PrintAttributes()
        {
            for (int i = 0; i < _genes.Length; i++)
            {
                Console.WriteLine(_genes[i]);
            }
        }
    }
}

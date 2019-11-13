using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Monster
    { 
        public enum Genders { male,female };
        public enum Types { bird,reptile,mammal };
        public enum Colors { red,blue,yellow };
        public enum Patterns { striped,pied,none };

        private int _id;
        private string name;
        private Genders _gender;
        private Types _type;
        private Colors _color;
        private Patterns _pattern;

        private int[] _genes;
        private string[] _family;

        static Random generator = new Random();

        public Monster(Genders gender)
        {
            //_gender = (Monster.Gender)1; konverterar int till Gender och indikerar att gender är male.
            //_gender = Monster.Gender.male; inebär att gender är male.

            _gender = (Monster.Genders)gender;
            _type = (Monster.Types)generator.Next(2);
            _color = (Monster.Colors)generator.Next(2);
            _pattern = (Monster.Patterns)generator.Next(2);
        }

        public Monster BreedWith(Monster partner)
        {

        }


        public void PrintAttributes()
        {

        }
    }
}

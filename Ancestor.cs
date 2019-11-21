using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Ancestor : Monster
    {
        public Ancestor(string name , Genders gender)
        {
            _name = name;

            //_gender = (Monster.Gender)1; konverterar int till Gender och indikerar att gender är male. 
            //_gender = Monster.Gender.male; inebär att gender är male.

            _gender = gender;
            _type = (Monster.Types)generator.Next(2);
            _color = (Monster.Colors)generator.Next(2);
            _pattern = (Monster.Patterns)generator.Next(2);
        }
    }
}

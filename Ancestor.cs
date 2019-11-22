using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    /* Ancestor utgör spelarens första monster och skapas i början av spelet.
     * Då de til skillnad från offsprings inte är framavlade deklareras namn och kön då konstruktorn skapas.
     * Gener och således även egenskaper slumpas fram.
     */

    class Ancestor : Monster
    {
        //I konstruktorn slumpas värden på egenskaper fram och lagras i monstrets gener.
        public Ancestor(string name , Genders gender)
        {
            _name = name;

            //NOTES TILL MIG SJÄLV:
            //_gender = (Monster.Gender)1; konverterar int till Gender och indikerar att gender är male. 
            //_gender = Monster.Gender.male; inebär att gender är male.

            _gender = gender;
            _type = (Monster.Types)Program.Generator.Next(3);
            _color = (Monster.Colors)Program.Generator.Next(3);
            _pattern = (Monster.Patterns)Program.Generator.Next(3);

            _genes = new int[4] { (int)_gender, (int)_type, (int)_color, (int)_pattern }; //NOTES TILL MIG SJÄLV: (int) indikerar att enum skall konverteras till int

        }
    }
}

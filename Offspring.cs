using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    class Offspring : Monster
    {
        private string[] _family;

        public Offspring()
        {
            _gender = (Monster.Genders)generator.Next(1);
            _type = (Monster.Types)generator.Next(2);
            _color = (Monster.Colors)generator.Next(2);
            _pattern = (Monster.Patterns)generator.Next(2);

            _genes = new int[4] { (int)_gender, (int)_type, (int)_color, (int)_pattern }; //(int) indikerar att enum skall konverteras till int
        }

        public void GetGenes()
        {

        }
    }

}

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
            _gender = 0;
            _type = 0;
            _color = 0;
            _pattern = 0;

            _genes = new int[4];
        }

        public void GetTraits()
        {
            _gender = (Monster.Genders)_genes[0];
            _type = (Monster.Types)_genes[1];
            _color = (Monster.Colors)_genes[2];
            _pattern = (Monster.Patterns)_genes[3];

        }
    }

}

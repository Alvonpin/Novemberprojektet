using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    /*Offsprings skapas när spelaren parar två monster
     *Till skillnad från ancestors saknar offspring information i konstruktorn,
     *detta då dess namn bestäms av spelaren och dess egenskaper slumpas fram beroende på dess föräldrars egenskaper.
     */

    class Offspring : Monster
    {
        private string[] _family; //Anger individens föräldrar, morföräldrar och farföräldrar. Om spelaren avlar besläktade djur får de sämre emunsystem.

        public Offspring() //Saknar information då individens egenskaper skapas utifrån föräldrarnas.
        {
            _name = "New Monster";
            _gender = 0;
            _type = 0;
            _color = 0;
            _pattern = 0;

            _genes = new int[4];
        }

        public void GetTraits() //Skapar egenskaper utifrån genetisk uppsättning
        {
            _gender = (Monster.Genders)_genes[0];
            _type = (Monster.Types)_genes[1];
            _color = (Monster.Colors)_genes[2];
            _pattern = (Monster.Patterns)_genes[3];

        }

        public void SetName(string input) 
        {
            _name = input;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
    //Klassen hanterar spelets text; hur den skrivs ut och hur den tas bort

    static class TextManager
    {
        //Skriver ut spelets instruktioner. Tar in en string som anger vilken instuktion som ska skrivas ut.

        public static void PrintInstruction(string instruction)
        {
            if (instruction == "Introduction")
            {
                Console.WriteLine("Select a monster, type the name of the creature and hit [ENTER] to select it");
                Console.WriteLine();
            }

            else if ( instruction == "Actions")
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do? Type the letter a, b or c and hit [ENTER]");

            }

            else if (instruction == "SelectFemale")
            {
                Console.WriteLine();
                Console.WriteLine("Select a female");
                Console.WriteLine();
            }

            else if (instruction == "SelectMale")
            {
                Console.WriteLine();
                Console.WriteLine("Select a male");
                Console.WriteLine();
            }

            else if (instruction == "Name")
            {
                Console.WriteLine("Name your new monster");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("error");
            }
        }

        //Skriver ut valmöjligheter

        public static void PrintChoises()
        {
            Console.WriteLine();
            Console.WriteLine("a) Breed");
            Console.WriteLine("b) Check traits");
            Console.WriteLine("c) Remove creature");
            Console.WriteLine( );
        }

        //Tar bort angiven text. Tar in en string som anger vad som skall tas bort.
        public static void Clear(string text)
        {
            if (text == "All")
            {
                Console.Clear();
            }

            else
            {
                Console.Clear();
                PrintInstruction(text);
            }
        }


    }
}

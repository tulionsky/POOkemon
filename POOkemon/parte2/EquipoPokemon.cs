using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon.parte2
{
    internal class EquipoPokemon
    {
        private Pkmn[] pkmns;

        public EquipoPokemon()
        {
            pkmns = new Pkmn[5];

            pkmns[0] = new Pkmn("Pikachu", "Kanto");
            pkmns[1] = new Pkmn("Charmander", "Kanto");
            pkmns[2] = new Pkmn("Togepi", "Johto");
            pkmns[3] = new Pkmn("Snorlax", "Kanto");
            pkmns[4] = new Pkmn("Infernape", "Sinnoh");

        }

        public Pkmn this[int index]
        {
            get { return pkmns[index]; }
            set { pkmns[index] = value; }
        }
    }
}
